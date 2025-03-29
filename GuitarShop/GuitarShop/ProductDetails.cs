using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Console;
using System.Collections;
using System.Windows.Documents;

namespace GuitarShop
{
    public partial class ProductDetails : Form
    {
        
        public int loadId = 0;       //從Products傳商品ID過來         
        public ArrayList Product_items = new ArrayList();   //存取購物車品項        
        int Product_id;         //產品ID
        string Proudct_name;    //產品名稱
        int Proudct_price;      //產品價格
        int productstocks ;     //紀錄商品庫存
        string FirstimagePath;  //第一張圖片路徑
        

        public ProductDetails()
        {
            InitializeComponent();
        }

        void Loadproducts(string query) 
        {
            if (loadId > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();               
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SearchID", loadId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) //讀取第一筆資料
                {
                    Product_id = (int)reader["Product_id"];
                    Proudct_name = reader["Product_Name"].ToString();
                    Proudct_price = (int)reader["Product_Price"];
                    string Product_Description = reader["Product_Description"].ToString();
                    //int Product_Stock = (int)reader["Product_Stock"];
                    productstocks = (int)reader["Product_Stock"];
                    string Product_Category = reader["Product_Category"].ToString();
                    string imagePath = reader["FilePath"].ToString();                      
                    int ImageID = (int)reader["SortOrder"];
                    string CompletePath = GlobalVar.image_dir + imagePath;
                    FirstimagePath = GlobalVar.image_dir + imagePath;
                    CreateImages(FirstimagePath, ImageID);

                    lbProductName.Text = Proudct_name;
                    lbProductDescription.Text = Product_Description;
                    lbDiscountPrice.Text = $"NT${Proudct_price}";
                    lbPrice.Text = $"NT${Proudct_price * 1.1}";
                    lbInventory.Text = $"庫存：{productstocks}";
                    picMain.Image = Image.FromFile(CompletePath);                   
                }
                int count = 1;
                while (reader.Read())  //會開始從第二筆資料讀取
                {
                    string imagePath = reader["FilePath"].ToString();
                    string CompletePath = GlobalVar.image_dir + imagePath;
                    int ImageID = (int)reader["SortOrder"];
                    //加入picBox
                    CreateImages(CompletePath, ImageID);
                    count++;
                };              
                reader.Close();
                con.Close();
            }
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            string query = "select * from Products P join Images I on I.Product_Id = P.Product_Id where P.Product_id = @SearchID";
            Loadproducts(query);            
        }

        void CreateImages(string path,int id) 
        {          
            PictureBox pictureBox = new PictureBox();
            pictureBox.Tag = id;
            pictureBox.Size = new Size(110, 110);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile(path);
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.Click += new EventHandler(pictureBox_Click);
            FLPimage.Controls.Add(pictureBox);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            int picID = (int)picture.Tag;
            picMain.Image = picture.Image;            
        }                          
             
        void isStocks()
        {
            if (txtNums.Value > productstocks)
            {
                txtNums.Value = 1;
                MessageBox.Show($"庫存不足，剩餘數量{productstocks}");
            }
        }

        private void txtNums_ValueChanged(object sender, EventArgs e)
        {
            isStocks();           
        }

        private void btnAddshopcart_Click(object sender, EventArgs e)
        {
            Product_items = new ArrayList
            {
                Product_id,
                Proudct_name,
                Proudct_price,
                txtNums.Value,
                FirstimagePath,
                Proudct_price * txtNums.Value,
                productstocks
            };

            // 判斷購物車中是否已經有相同的商品ID  
            if (GlobalVar.ShoppingCart.ContainsKey(Product_id))
            {
                // 如果商品ID已存在，更新數量與總價
                var cartItem = GlobalVar.ShoppingCart[Product_id];
                int CuerrentQuantity = Convert.ToInt32(cartItem[3]);   //目前購物車品項數量
                int newQuantity = CuerrentQuantity + Convert.ToInt32(txtNums.Value); //更新購物車品項數量

                // 檢查是否超過庫存
                if (newQuantity > productstocks)
                {
                    MessageBox.Show($"庫存不足，剩餘數量 {productstocks}");
                    newQuantity = productstocks;
                    return; // 直接返回以防止繼續執行
                }

                // 若無超過庫存，更新購物車中的數量與總價
                cartItem[3] = newQuantity;
                cartItem[5] = newQuantity * Proudct_price;
            }
            else
            {
                // 如果購物車中沒有重複項目，則新增新項目
                GlobalVar.ShoppingCart.Add(Product_id, Product_items);
            }
            MessageBox.Show("已加入購物車!");                               
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
        }
    }
}
