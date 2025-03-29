
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuitarShop
{
    public partial class AddPhotoForm : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public int productID;
        public string Product_Name;
        private int PhotoID;
        private int DGV_count;
        private string selectedImagePath; // 用於儲存選擇的圖片路徑
        public AddPhotoForm()
        {
            InitializeComponent();
        }
        private void AddPhotoForm_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            lbproductID.Text = $"商品ID：{productID.ToString()}";
            lbproductname.Text = $"商品名稱：{Product_Name}";
            searchPhoto();
        }

        void searchPhoto()
        {
            try
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string query = "select Image_ID as '圖片ID',FilePath as '圖片路徑',SortOrder as '排序編號' from Images where Product_Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", productID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGV_count = dt.Rows.Count;
                    DGVPhoto.DataSource = dt;
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show($"讀取失敗，錯誤訊息: {ex.Message}"); }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath); // 顯示圖片於 PictureBox
            }   
        }


        private void DGVPhoto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGV_count)
            {
                PhotoID = Convert.ToInt32(DGVPhoto.Rows[e.RowIndex].Cells["圖片ID"].Value);
                string ImagePath = DGVPhoto.Rows[e.RowIndex].Cells["圖片路徑"].Value.ToString();
                int Sort = Convert.ToInt32(DGVPhoto.Rows[e.RowIndex].Cells["排序編號"].Value);
                string CompletePath = GlobalVar.image_dir + ImagePath;
                pictureBox1.Image = Image.FromFile(CompletePath);

                lbphotoID.Text = $"圖片ID：{PhotoID.ToString()}";
                NumSort.Value = Sort;
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            if (selectedImagePath != null)
            {
                string fileName = Path.GetFileName(selectedImagePath); // 取得圖片名稱
                string destinationPath = Path.Combine(GlobalVar.image_dir, fileName); // 設定圖片儲存路徑
                
                try
                {
                    // 將圖片複製到目的地資料夾
                    File.Copy(selectedImagePath, destinationPath, true);

                    // 將圖片路徑資訊儲存到資料庫
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();

                    // 先取得目前該商品的最大 SortOrder 值
                    string queryMaxSortOrder = "SELECT ISNULL(MAX(SortOrder), 0) FROM Images WHERE Product_Id = @ProductId";
                    SqlCommand cmdMax = new SqlCommand(queryMaxSortOrder, con);
                    cmdMax.Parameters.AddWithValue("@ProductId", productID);
                    int maxSortOrder = (int)cmdMax.ExecuteScalar();

                    string query = "INSERT INTO Images (Product_Id, FilePath, SortOrder) VALUES (@ProductId, @FilePath, @SortOrder)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ProductId", productID); // 假設 Product_Id 為 1，可以根據需求更改
                    cmd.Parameters.AddWithValue("@FilePath", fileName);
                    cmd.Parameters.AddWithValue("@SortOrder", maxSortOrder + 1); // 設定排序，可以自動增量或根據需要設定

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("圖片上傳成功！");
                    con.Close();
                    searchPhoto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("圖片上傳失敗：" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("請先選取圖片！");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (PhotoID > 0)
            {
                var result = MessageBox.Show($"是否刪除圖片ID: {PhotoID} 資料?", "刪除照片", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                        con.Open();
                        string query = "delete Images where Image_ID = @photoID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@photoID", PhotoID);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("資料刪除成功");
                        searchPhoto();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("圖片刪除失敗：" + ex.Message);
                    }
                }
              
            }
            else
            {
                MessageBox.Show("請先選取要刪除的圖片！");
            }
        }

        private void btnSetSort_Click(object sender, EventArgs e)
        {
            if (PhotoID > 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string query = "update Images SET SortOrder = @newSort where Image_ID = @photoID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@photoID", PhotoID);
                    cmd.Parameters.AddWithValue("@newSort", NumSort.Value);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("排序更新成功");
                    searchPhoto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("排序更新失敗：" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("請先選取要更改的圖片！");
            }

        }
    }
   
}
