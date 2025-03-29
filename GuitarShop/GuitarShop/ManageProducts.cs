using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuitarShop
{
    public partial class ManageProducts : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        private int DGV_count;
        private int productID;
        public ManageProducts()
        {
            InitializeComponent();
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            //首行插入編輯按鈕
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "編輯";
            editButtonColumn.Name = "EditButton";
            editButtonColumn.Text = "編輯";
            editButtonColumn.FlatStyle = FlatStyle.Flat;
            editButtonColumn.UseColumnTextForButtonValue = true;
            DGVproduct.Columns.Insert(0, editButtonColumn);

            DataGridViewButtonColumn addphoto = new DataGridViewButtonColumn();
            addphoto.HeaderText = "新增刪除照片";
            addphoto.Name = "addButton";
            addphoto.Text = "新增刪除照片";
            addphoto.FlatStyle = FlatStyle.Flat;
            addphoto.UseColumnTextForButtonValue = true;
            DGVproduct.Columns.Insert(1, addphoto);

            searchAll();
        }

        void searchAll() 
        {
            try 
            { 
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string query = "select Product_Id as '商品編號',Product_Name as '商品名稱',Product_Price as '商品價格',Product_Description as '商品描述', Product_Stock as '商品庫存',Product_Category as '商品種類' from Products";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true) 
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGV_count=dt.Rows.Count;
                    DGVproduct.DataSource = dt;
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取失敗，錯誤訊息: {ex.Message}");
            }
        }

        private void DGVproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DGVproduct.Columns["EditButton"].Index && e.RowIndex >= 0
                && e.RowIndex < DGV_count) 
                {
                    productID = Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["商品編號"].Value);
                    int ProductID = Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["商品編號"].Value);
                    string name = DGVproduct.Rows[e.RowIndex].Cells["商品名稱"].Value.ToString();
                    int Price = Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["商品價格"].Value);
                    string Description = DGVproduct.Rows[e.RowIndex].Cells["商品描述"].Value.ToString();
                    int stocks = Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["商品庫存"].Value);
                    string type = DGVproduct.Rows[e.RowIndex].Cells["商品種類"].Value.ToString();

                    txtPname.Text = name;
                    txtprice.Text = Price.ToString();
                    NumStock.Value = stocks;
                    CBtype.Text = type;
                    txtDescribe.Text = Description; 

                    Console.WriteLine($"{ProductID} {name} {Price} {Description} {stocks} {type}");
                }
                if (e.ColumnIndex == DGVproduct.Columns["addButton"].Index && e.RowIndex >= 0
               && e.RowIndex < DGV_count)
                {
                    int ProductID = Convert.ToInt32(DGVproduct.Rows[e.RowIndex].Cells["商品編號"].Value);
                    string name = DGVproduct.Rows[e.RowIndex].Cells["商品名稱"].Value.ToString();
                    AddPhotoForm addPhotoForm = new AddPhotoForm();
                    addPhotoForm.productID = ProductID;
                    addPhotoForm.Product_Name= name;
                    addPhotoForm.ShowDialog();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"讀取失敗，錯誤訊息: {ex.Message}");
            }

        }
        void AddProduct()
        {
            if ((txtPname.Text != "") && (txtprice.Text != "") && (CBtype.Text != "") && (NumStock.Value != 0))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string insert = "insert into Products(Product_Name,Product_Price,Product_Description,Product_Stock,Product_Category) \r\nValues(@Name,@Price,@Description,@stock,@Category)";
                SqlCommand cmd = new SqlCommand(insert,con);
                cmd.Parameters.AddWithValue("@Name",txtPname.Text.Trim());
                cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(txtprice.Text.Trim()));
                cmd.Parameters.AddWithValue("@Description", txtDescribe.Text.Trim());
                cmd.Parameters.AddWithValue("@stock", NumStock.Value);
                cmd.Parameters.AddWithValue("@Category", CBtype.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show($"資料新增成功");
                con.Close();
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProduct();
            searchAll();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (productID > 0 && (txtPname.Text != "") && (txtprice.Text != "") && (CBtype.Text != "") && (NumStock.Value != 0))
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string update = "update products set Product_Name=@Name,Product_Price=@price,Product_Description=@Description,Product_Stock=@stock,Product_Category=@Category where Product_id = @ProductID ;";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@Name", txtPname.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", Convert.ToInt32(txtprice.Text.Trim()));
                    cmd.Parameters.AddWithValue("@stock", NumStock.Value);
                    cmd.Parameters.AddWithValue("@Category", CBtype.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", txtDescribe.Text.Trim());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("商品更新成功！");
                }
                else
                {
                    MessageBox.Show("資訊欄位不完整");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"更新失敗，錯誤訊息: {ex.Message}");
            }
           
            searchAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                var result = MessageBox.Show($"是否刪除ID: {productID} 資料?", "刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string delete = "delete Images where Product_Id =@ID ; delete Products where Product_Id =@ID";
                    SqlCommand cmd = new SqlCommand(delete, con);
                    cmd.Parameters.AddWithValue("@ID", productID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("資料刪除成功");
                }
                   
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"刪除失敗，錯誤訊息: {ex.Message}");
            }
            searchAll();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection con = new SqlConnection (GlobalVar.strDBConnectionString);
                con.Open();
                string query = "select Product_Id as '商品編號',Product_Name as '商品名稱',Product_Price as '商品價格',Product_Description as '商品描述', Product_Stock as '商品庫存',Product_Category as '商品種類' from Products where Product_Name = @Name ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtPname.Text.Trim());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGV_count = dt.Rows.Count;
                    DGVproduct.DataSource = dt;
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"查詢失敗，錯誤訊息: {ex.Message}");
            }
        }
    }
}
