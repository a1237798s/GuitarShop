using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Console;
using static GuitarShop.ProductCard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Runtime.InteropServices;


namespace GuitarShop
{
    public partial class ProductsForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        private RegisterControl registerControl; //註冊畫面
        private LoginControl loginControl;  //登陸畫面
        
        private MemberInfo memberInfo;      //會員資訊       
        
        private bool isCartPanelVisible = false;  //購物車是否顯示

        public ProductsForm()
        {
            InitializeComponent();         

            loginControl = new LoginControl { Dock = DockStyle.Fill };
            registerControl = new RegisterControl { Dock = DockStyle.Fill };
            memberInfo = new MemberInfo {  Dock = DockStyle.Fill };
            

            panelContainer.Width=0; //一開始先不要顯示購物車
            // 訂閱 loginControl 的 ShowRegister 事件                                           
            loginControl.ShowRegister += LoginControl_ShowRegister;
            //loginControl.ShowProudcts += LoginControl_ShowProudcts;
            registerControl.ShowLogin += RegisterControl_ShowLogin;
            loginControl.ShowMemberInfo += LoginControl_ShowMemberInfo;
            loginControl.ClosePanelLeft += LoginControl_ClosePanelLeft;
            memberInfo.ShowProductsFromAccount += Signout;
            
        }

        private void updateTotal(object sender, EventArgs e)
        {
            if (GlobalVar.ShoppingCart.Count > 0)
            {
                int sum = 0;
                foreach (var item in GlobalVar.ShoppingCart)
                {                   
                    sum += Convert.ToInt32(item.Value[5]);
                }
                lbCarttotal.Text = $"${sum}";
            }
            else
            {
               
                lbCarttotal.Text = "$0";
            }
        }
            

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            Currently_User.Text = GlobalVar.Currently_UserName;
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            string Query = "select * from Products P join Images I on I.Product_Id = P.Product_Id where I.SortOrder = 1";
            LoadProducts(Query);

            /* 使用者登入顯示商品管理系統 */
            if (GlobalVar.isAdmin)
            {
                btnProductManager.Visible = true;

            }
            else { btnProductManager.Visible = false; }
        }

        private void ProductsForm_Activated(object sender, EventArgs e)
        {
            Currently_User.Text = GlobalVar.Currently_UserName;
            AddCart();
        }

        /* 讀取產品 */
        public void LoadProducts(string Query)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int Count = 0;
            while (reader.Read())
            {
                int Product_id = (int)reader["Product_id"];
                string Proudct_name = reader["Product_Name"].ToString();
                int Proudct_price = (int)reader["Product_Price"];
                string imagePath = reader["FilePath"].ToString();
                string CompletePath = GlobalVar.image_dir + imagePath;               

                // 創建 ProductCard 並設置資料
                ProductCard productCard = new ProductCard { productCardID = Product_id };
              
                productCard.lblProductName.Text = Proudct_name;
                productCard.lblProductPrice.Text = "NT$" + Proudct_price.ToString("N0");

                // 加載圖片
                if (File.Exists(CompletePath))
                {
                    productCard.pictureBoxProduct.Image = Image.FromFile(CompletePath);
                }
                // 將 ProductCard 添加到 FlowLayoutPanel
                flowLayoutPanelAll.Controls.Add(productCard);
                Count++;
            }
            
            reader.Close();
            con.Close();
        }                             
        private void ShopCart_Click(object sender, EventArgs e)
        {
            isCartPanelVisible = !isCartPanelVisible;
            CartPanelVisible();
        }
        private void lbCartNum_Click(object sender, EventArgs e)
        {
            isCartPanelVisible = !isCartPanelVisible;
            CartPanelVisible();
        }

        /* 購物車顯示功能 */
        void CartPanelVisible() 
        {
            if (GlobalVar.ShoppingCart.Count > 0)
            {
                if (isCartPanelVisible)
                {
                    panelContainer.Controls.Add(CartContainerPanel);
                    CartContainerPanel.Width = 317;                    
                }
                else
                {
                    panelContainer.Controls.Remove(CartContainerPanel);
                    CartContainerPanel.Width = 0;
                }
            }
            else 
            {
                panelContainer.Controls.Remove(CartContainerPanel);
                CartContainerPanel.Width = 0;
            }
        }
               

        private void btnAGfilter_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(flowLayoutPanelAll);
            flowLayoutPanelAll.Controls.Clear();
            string Query = "select * from Products P join Images I on I.Product_Id = P.Product_Id where (Product_Category = 'AG' and I.SortOrder = 1);";
            LoadProducts(Query);
        }

        private void btnEGfilter_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(flowLayoutPanelAll);
            flowLayoutPanelAll.Controls.Clear();
            string Query = "select * from Products P join Images I on I.Product_Id = P.Product_Id where (Product_Category = 'EG' and I.SortOrder = 1);";
            LoadProducts(Query);
        }


        /* 隱藏購物車 */
        public void HideCartPanel()
        {
            isCartPanelVisible = false;
            panelContainer.Controls.Remove(CartContainerPanel);
            CartContainerPanel.Width = 0;
        }

        /* 加入購物車物件 */
        public void AddCart() 
        {   
            cartItemPanel.Controls.Clear();
            if (GlobalVar.ShoppingCart.Count > 0)
            {
                /* 設定購物車圖示數量 */
                lbCartNum.Text = GlobalVar.ShoppingCart.Count.ToString();
                int sum = 0;
                foreach (var item in GlobalVar.ShoppingCart)
                {                    
                    //創建購物車品項
                    CartItemControl cartItemControl = new CartItemControl();
                    cartItemControl.QuantityChanged += CartItemControl_QuantityChanged; //加入商品價格變更事件
                    cartItemControl.CartID = item.Key;      //這是productID
                    cartItemControl.productID = Convert.ToInt32(item.Value[0]);
                    cartItemControl.lbCartPname.Text = $"{item.Value[1]}";
                    cartItemControl.lbCartUnitPrice.Text = $"${item.Value[2]}";
                    cartItemControl.CartItemNum.Value = Convert.ToInt32(item.Value[3]);
                    cartItemControl.picCart.Image = Image.FromFile(item.Value[4].ToString());
                    cartItemControl.lbCartItemTotal.Text = $"${item.Value[5]}";
                    cartItemPanel.Controls.Add(cartItemControl);
                    sum += Convert.ToInt32(item.Value[5]);                    
                }
                lbCarttotal.Text = $"${sum}";
            }
            else 
            {
                HideCartPanel();
                lbCarttotal.Text = "$0";
            }
        }

        /* 更新購物車全部商品總價 */
        private void CartItemControl_QuantityChanged(object sender, EventArgs e)
        {
            int totalPrice = GlobalVar.ShoppingCart.Sum(item => Convert.ToInt32(item.Value[5]));
            lbCarttotal.Text = $"${totalPrice}";
        }
      


        private void LoginControl_ShowRegister(object sender, EventArgs e)
        {
            // 切換到註冊頁面
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(registerControl);
        }

        private void RegisterControl_ShowLogin(object sender, EventArgs e)
        {
            // 切換到登陸頁面
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(loginControl);
        }

        private void Signout(object sender, EventArgs e)
        {
            // 登出後切換到商品頁面
           
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(flowLayoutPanelAll);
            panelLeft.Width = 150;
            GlobalVar.Currently_UserID = 0;
            GlobalVar.Currently_UserName = "訪客";
            GlobalVar.Currently_UserEmail = "";
            GlobalVar.Currently_UserPhone = "";
            GlobalVar.isLogin = false;
            
            Currently_User.Text = GlobalVar.Currently_UserName;
        }

        private void LoginControl_ShowMemberInfo(object sender, EventArgs e)
        {
            // 切換到會員頁面
            panelContainer.Controls.Clear();    
            panelContainer.Controls.Add(memberInfo);
        }

        private void LoginControl_ClosePanelLeft(object sender, EventArgs e) 
        {
            //當會員登入後把左邊欄位縮小
            if (GlobalVar.isLogin)
            { 
                panelLeft.Width = 0;
            }
            else 
            {
               panelLeft.Width = 150;
            }           
        }

        private void Member_Click(object sender, EventArgs e)
        {            
            if (GlobalVar.isLogin) 
            {
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(memberInfo);
                panelLeft.Width = 0;
            }
            else 
            {
                panelContainer.Controls.Clear();
                panelLeft.Width = 150;
                panelContainer.Controls.Add(loginControl);
            }            
        }

        private void panelContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
           Currently_User.Text = GlobalVar.Currently_UserName;
        }

        private void panelContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            Currently_User.Text = GlobalVar.Currently_UserName;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(flowLayoutPanelAll);
            flowLayoutPanelAll.Controls.Clear();
            string Query = "select * from Products P join Images I on I.Product_Id = P.Product_Id where I.SortOrder = 1";
            LoadProducts(Query);
            panelLeft.Width = 150;
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
        }

        private void btnProductManager_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();
            manageProducts.ShowDialog();
        }
    }
}
