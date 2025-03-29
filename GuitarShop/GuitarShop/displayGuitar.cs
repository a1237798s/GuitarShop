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
namespace GuitarShop
{
    public partial class displayGuitar : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<int> List_Products_ID = new List<int>();  //key
        List<string> List_Products_Name = new List<string>();
        List<int> List_Products_Price = new List<int>();
        

        public displayGuitar()
        {
            InitializeComponent();      
        }

        private void displayGuitar_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true ;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            LoadingDatabase();
        }

        public void LoadingDatabase() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string Query = "select * from Products P join Images I on I.Product_Id = P.Product_Id where I.SortOrder = 1";
            SqlCommand sqlCommand = new SqlCommand(Query, con);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            int Count = 0;
            while (reader.Read()) 
            {
                List_Products_ID.Add((int)reader["Product_Id"]);
                List_Products_Name.Add((string)reader["Product_Name"]);
                List_Products_Price.Add((int)reader["Product_Price"]);
                string Image_path =GlobalVar.image_dir  + ((string)reader["FilePath"]);
                WriteLine(Image_path);  //確認路徑是否正確
                System.IO.FileStream fs = System.IO.File.OpenRead(Image_path);
                Image img = Image.FromStream(fs);
                imageList.Images.Add(img);
                fs.Close();
                Count++;
            }
            WriteLine($"共有{Count}筆資料");
            reader.Close();
            con.Close();
        }

        void displayimage() 
        {            
            imageList.ImageSize = new Size(100,100);

            for (int idx = 0; idx < List_Products_ID.Count; idx ++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = idx;
                item.Text = $"{List_Products_Name[idx]} {List_Products_Price[idx]}元";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                item.Tag = List_Products_ID[idx];
                listView商品展示.Items.Add(item);
            }
        }

        private void LoadProductImages()
        {
            
        }

            private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {         
           
        }

        
    }
}
