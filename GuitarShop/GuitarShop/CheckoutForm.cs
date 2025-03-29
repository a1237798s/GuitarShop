using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShop
{
    public partial class CheckoutForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int PaymentMethod ; //信用卡:0  數位支付:1  貨到付款:2 
        
        
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            /* 伺服器位置 */
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            LoadCart();
            if (GlobalVar.isLogin)
            {
                panelNoLogin.Visible = false;
                panelLoggedin.Visible = true;
                txtName.Text = GlobalVar.Currently_UserName;
                txtPhone.Text = GlobalVar.Currently_UserPhone;
                lbMemberEmail.Text = GlobalVar.Currently_UserEmail;
            }
            else
            {
                panelNoLogin.Visible = true;
                panelLoggedin.Visible = false;
            }
        }

        void LoadCart()
        {
            if (GlobalVar.ShoppingCart.Count > 0)
            {
                /* 設定購物車圖示數量 */
                lbCartNum.Text = $"購物車內合計有 {GlobalVar.ShoppingCart.Count.ToString()} 項商品";
                int sum = 0;
                foreach (var item in GlobalVar.ShoppingCart)
                {
                    //創建購物車品項
                    CartItemCheck cartItemCheck = new CartItemCheck();
                    cartItemCheck.QuantityChanged += CartItemControl_QuantityChanged; //加入商品價格變更事件
                    cartItemCheck.CartID = item.Key;      //這是productID
                    cartItemCheck.productID = Convert.ToInt32(item.Value[0]);
                    cartItemCheck.lbPName.Text = $"{item.Value[1]}";
                    cartItemCheck.lbUnitPrice.Text = $"${item.Value[2]}";
                    cartItemCheck.txtNum.Text =item.Value[3].ToString();
                    cartItemCheck.picproduct.Image = Image.FromFile(item.Value[4].ToString());
                    cartItemCheck.lbitemTotal.Text = $"${item.Value[5]}";
                    FLPcart.Controls.Add(cartItemCheck);
                    sum += Convert.ToInt32(item.Value[5]);
                }
                lbTotal.Text = $"總價：${sum}";
            }
            else
            {
                lbTotal.Text = $"總價：$0";
            }
        }

        private void CartItemControl_QuantityChanged(object sender, EventArgs e) 
        {
            int totalPrice = GlobalVar.ShoppingCart.Sum(item => Convert.ToInt32(item.Value[5]));
            lbTotal.Text = $"總價：${totalPrice}";
        }

      

        private void panelLoggedin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
            {
                if (GlobalVar.ShoppingCart.Count > 0)
                {
                    /* 計算總金額 */
                    int sum = 0;
                    foreach (var item in GlobalVar.ShoppingCart)
                    {
                        sum += Convert.ToInt32(item.Value[5]);
                    }
                    try 
                    {
                        /* 建立Orders資料 */
                        using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                        {
                            con.Open();
                            string strSQL = "INSERT INTO Orders(Member_Id,PaymentMethod,name,Phone,Email,address,TotalAmount) " +
                                "VALUES(" +
                                "@ID," +
                                "@Payment," +
                                "@Name," +
                                "@Phone," +
                                "@Email," +
                                "@Address," +
                                "@TotalAmount);" +
                                "SELECT SCOPE_IDENTITY();"; // 這行會返回新插入的OrderID
                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            string strPayment = "";

                            switch (PaymentMethod)
                            {
                                case 0:
                                    strPayment = "信用卡";
                                    break;
                                case 1:
                                    strPayment = "數位支付";
                                    break;
                                case 2:
                                    strPayment = "貨到付款";
                                    break;
                                default:
                                    strPayment = "現金";
                                    break;
                            }
                            if (GlobalVar.isLogin)
                            {
                                cmd.Parameters.AddWithValue("@Email", lbMemberEmail.Text.Trim());
                            }
                            else 
                            {
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            }
                            cmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);
                            cmd.Parameters.AddWithValue("@Payment", strPayment);
                            cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                           
                            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@TotalAmount", sum);

                            // 執行SQL並獲取新的OrderID
                            int newOrderID = Convert.ToInt32(cmd.ExecuteScalar());

                            /* 插入OrderDetails資料 */
                            string queryDetail = "INSERT INTO OrdersDetails(Order_Id,Product_Id,Product_Name,Quantity,UnitPrice,TotalAmount) VALUES(@Order_Id,@Product_Id,@Product_Name,@Quantity,@UnitPrice,@TotalAmount)";
                            foreach (var item in GlobalVar.ShoppingCart)
                            {
                                SqlCommand cmdDetail = new SqlCommand(queryDetail, con);
                                cmdDetail.Parameters.AddWithValue("@Order_Id", newOrderID);
                                cmdDetail.Parameters.AddWithValue("@Product_Id", Convert.ToInt32(item.Value[0]));
                                cmdDetail.Parameters.AddWithValue("@Product_Name", item.Value[1].ToString());
                                cmdDetail.Parameters.AddWithValue("@UnitPrice", Convert.ToInt32(item.Value[2]));
                                cmdDetail.Parameters.AddWithValue("@Quantity", Convert.ToInt32(item.Value[3]));
                                cmdDetail.Parameters.AddWithValue("@TotalAmount", Convert.ToInt32(item.Value[5]));

                                cmdDetail.ExecuteNonQuery();

                            }

                            MessageBox.Show("已收到您的訂單!");
                        }
                    }
                    catch (Exception ex) 
                    {                        
                        throw new Exception("建立訂單失敗: " + ex.Message);
                    }
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("購物車無添加任何商品!");
                }
            }
            else 
            {
                MessageBox.Show("訂購人資訊請填寫完整!!!");
            }
        }


        
        private void RBCOD_CheckedChanged(object sender, EventArgs e)
        {
            PaymentMethod = 2;
        }

        private void RBcreditcard_CheckedChanged(object sender, EventArgs e)
        {
            PaymentMethod = 0;
        }

        private void RBdigitalpayment_CheckedChanged(object sender, EventArgs e)
        {
            PaymentMethod = 1;
        }


        //驗證信箱的正確性
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        //驗證手機的正確性
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^09\d{8}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            // 檢查手機跟Email格式
            if (!IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("請輸入有效的手機號碼");
                return;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            // 檢查手機跟Email格式
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("請輸入有效電子郵件地址");
                return;
            }
        }
    }
}
