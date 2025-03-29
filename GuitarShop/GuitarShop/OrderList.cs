using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShop
{
    public partial class OrderList : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        
        int DGV_count;
        public OrderList()
        {
            InitializeComponent();

            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            //首行插入編輯按鈕
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "訂單詳情";
            editButtonColumn.Name = "EditButton";
            editButtonColumn.Text = "訂單詳情";
            editButtonColumn.FlatStyle = FlatStyle.Flat;
            editButtonColumn.UseColumnTextForButtonValue = true;

            DGV_Orders.Columns.Insert(0, editButtonColumn);
            CBpayment.SelectedIndex = 0;
            SearchAll();

        }

        void SearchAll()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                {
                    con.Open();
                    string query = "select Order_Id as '訂單編號',Member_Id as '會員編號',name as '會員姓名',Phone as '會員電話',Email as 'Email',address as '地址' ,PaymentMethod as '付款方式',\r\nTotalAmount as '訂單總價',CreatedDate as '訂單日期' from Orders";
                    SqlCommand cmd = new SqlCommand(query, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows == true)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            DGV_count = dt.Rows.Count;
                            DGV_Orders.DataSource = dt;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取失敗，錯誤訊息: {ex.Message}");
            }

        }

        private void DGV_Orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // 確保點擊的是「編輯」按鈕
                if (e.ColumnIndex == DGV_Orders.Columns["EditButton"].Index && e.RowIndex >= 0
                && e.RowIndex < DGV_count)
                {
                    // 取得該行的資料，例如ID和其他欄位的值
                    int OrderID = Convert.ToInt32(DGV_Orders.Rows[e.RowIndex].Cells["訂單編號"].Value);                   
                    int Memberid = Convert.ToInt32(DGV_Orders.Rows[e.RowIndex].Cells["會員編號"].Value);
                    string name = DGV_Orders.Rows[e.RowIndex].Cells["會員姓名"].Value.ToString();
                    string phone = DGV_Orders.Rows[e.RowIndex].Cells["會員電話"].Value.ToString();
                    string email = DGV_Orders.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    string address = DGV_Orders.Rows[e.RowIndex].Cells["地址"].Value.ToString();
                    string payment = DGV_Orders.Rows[e.RowIndex].Cells["付款方式"].Value.ToString();
                    int OrderTotal = Convert.ToInt32(DGV_Orders.Rows[e.RowIndex].Cells["訂單總價"].Value);
                    DateTime OrderDate = (DateTime)DGV_Orders.Rows[e.RowIndex].Cells["訂單日期"].Value;

                    // 呼叫方法顯示 OrderDetails
                    OrderDetailsForm orderDetailsForm = new OrderDetailsForm(OrderID);
                    orderDetailsForm.Show();

                   

                    Console.WriteLine($" {OrderID} {Memberid} {name} {phone} {email} {address} {payment} {OrderTotal} {OrderDate}  ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取失敗，錯誤訊息: {ex.Message}");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                string query = "select Order_Id as '訂單編號',Member_Id as '會員編號',name as '會員姓名',Phone as '會員電話',Email as 'Email',address as '地址' ,PaymentMethod as '付款方式',TotalAmount as '訂單總價',CreatedDate as '訂單日期' FROM Orders WHERE 1=1 and (CreatedDate >= @StartDay) and (CreatedDate <= @EndDay) ";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@StartDay", DTStartDate.Value);
                cmd.Parameters.AddWithValue("@EndDay", DTEndDate.Value.AddDays(1));
                // 根據用戶輸入的條件來動態生成 SQL 語句
                if (!string.IsNullOrWhiteSpace(txtName.Text))
                {
                    query += " AND name LIKE @name";
                    cmd.Parameters.AddWithValue("@name", "%" + txtName.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    query += " AND Phone LIKE @phone";
                    cmd.Parameters.AddWithValue("@phone", "%" + txtPhone.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    query += " AND Email LIKE @Email";
                    cmd.Parameters.AddWithValue("@Email", "%" + txtEmail.Text + "%");
                }

                if (!string.IsNullOrWhiteSpace(txtOrderID.Text))
                {
                    query += " AND Order_Id = @OrderID";
                    cmd.Parameters.AddWithValue("@OrderID", Convert.ToInt32(txtOrderID.Text));
                }

                if (CBpayment.SelectedIndex != 0)
                {
                    string payment = "";
                    switch (CBpayment.SelectedIndex)
                    {
                        case 1:
                            payment = "信用卡";
                            break;
                        case 2:
                            payment = "數位支付";
                            break;
                        case 3:
                            payment = "貨到付款";
                            break;
                        default:
                            return;
                    }
                    query += " AND PaymentMethod = @PaymentMethod";
                    cmd.Parameters.AddWithValue("@PaymentMethod", payment);
                }

                // 將查詢語句指派給 SqlCommand
                cmd.CommandText = query;
                cmd.Connection = new SqlConnection(GlobalVar.strDBConnectionString);

                // 執行查詢並顯示結果
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);

                DGV_Orders.DataSource = ordersTable;
                    
                
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"讀取失敗，錯誤訊息: {ex.Message}"); 
            }
        }
    }
}
