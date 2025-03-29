using System;
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
    public partial class ManageMember : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        int DGV_count;
        public ManageMember()
        {
            InitializeComponent();
        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            CustomDGV();

            SearchAll();
        }

        void SearchAll()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();
                string query = "select Member_Id as '會員編號' ,Member_Name as '姓名',Member_Phone as '電話', Member_Email as 'Email' , Member_Birthday as '生日' ,CreatedDate as '入會日期' from Members Where Member_Id >1000";
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        DGV_count = dt.Rows.Count;
                        DGVMembers.DataSource = dt;
                    }
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void CustomDGV()
        {
            //首行插入編輯按鈕
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "編輯";
            editButtonColumn.Name = "EditButton";
            editButtonColumn.Text = "編輯";
            editButtonColumn.FlatStyle = FlatStyle.Flat;
            editButtonColumn.UseColumnTextForButtonValue = true;
            

            DGVMembers.Columns.Insert(0, editButtonColumn);
        }

        void SearchOne(int ID)
        {
            if (ID > 0)
            {                
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Members where Member_id = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", ID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lbID.Text = reader["Member_id"].ToString();
                    txtName.Text = (string)reader["Member_Name"];
                    txtPhone.Text = (string)reader["Member_Phone"];
                    txtEmail.Text = (string)reader["Member_Email"];  
                    DTbirthday.Value = (DateTime)reader["Member_Birthday"];                  
                }
                else
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
        }

        private void DGV_Member_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 確保點擊的是「編輯」按鈕
            if (e.ColumnIndex == DGVMembers.Columns["EditButton"].Index && e.RowIndex >= 0
                && e.RowIndex < DGV_count)
            {
                // 取得該行的資料，例如ID和其他欄位的值
                int id = Convert.ToInt32(DGVMembers.Rows[e.RowIndex].Cells["會員編號"].Value);
                string name = DGVMembers.Rows[e.RowIndex].Cells["姓名"].Value.ToString();
                string phone = DGVMembers.Rows[e.RowIndex].Cells["電話"].Value.ToString();
                string email = DGVMembers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                DateTime x = (DateTime)DGVMembers.Rows[e.RowIndex].Cells["生日"].Value;
                string birthday = x.ToString("yyyy/MM/dd");
                Console.WriteLine($"{id} {name} {phone} {email} {birthday}");
                SearchOne(id);
                
            }
            
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

        bool IRegister()
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();
                string query = "SELECT Member_Phone, Member_Email FROM Members;";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string M_Phone = reader["Member_Phone"].ToString();
                    string M_Email = reader["Member_Email"].ToString();

                    if (M_Phone == txtPhone.Text)
                    {
                        MessageBox.Show("電話已經有人使用");
                        txtPhone.Text = "";
                        reader.Close();
                        return false;
                    }
                    else if (M_Email == txtEmail.Text)
                    {
                        MessageBox.Show("Email已經有人使用");
                        txtEmail.Text = "";
                        reader.Close();
                        return false;
                    }
                }

                reader.Close(); // 確保關閉 reader
            }

            // 若沒有重複的電話或 Email，則返回 true
            return true;
        }

        void AddMember() 
        {
            if ((txtName.Text != "") && (txtPhone.Text != "") && (txtEmail.Text != ""))
            {
                if (checkPhoneEamil()) 
                { 
                    if (IRegister())
                    {
                        using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                        {
                            con.Open();
                            string query = "INSERT INTO Members(Member_Name,Member_Phone,Member_Email,Member_Birthday,Member_Passwords) VALUES" + "(@Name,@Phone,@Email,@Birthday,@Password)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@Birthday", (DateTime)DTbirthday.Value);
                            cmd.Parameters.AddWithValue("@Password", txtPhone.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show($"資料新增成功");
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("欄位資料不齊全");
            }

        }

        private void DGV_Member_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMember();
            SearchAll();
        }

        bool checkPhoneEamil() 
        {
            if (!IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("請輸入有效的手機號碼");
                return false;
            }
            // 檢查手機跟Email格式
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("請輸入有效電子郵件地址");
                return false;
            }
            return true;
        }
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            //// 檢查手機跟Email格式
            //if (!IsValidPhoneNumber(txtPhone.Text))
            //{
            //    MessageBox.Show("請輸入有效的手機號碼");
            //    return;
            //}
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //// 檢查手機跟Email格式
            //if (!IsValidEmail(txtEmail.Text))
            //{
            //    MessageBox.Show("請輸入有效電子郵件地址");
            //    return;
            //}
        }
        void ClearAll() 
        {
            lbID.Text = "0000";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = string.Empty;
            DTbirthday.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int intID = Convert.ToInt32(lbID.Text);
            if (intID >1000 && txtName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "")
            {
                if (checkPhoneEamil())
                {
                    using (SqlConnection conn = new SqlConnection(GlobalVar.strDBConnectionString))
                    {
                        conn.Open();

                        // 首先，檢查資料庫中是否有相同的手機號碼或電子郵件，排除當前會員的 ID
                        string checkQuery = "SELECT COUNT(*) FROM Members WHERE (Member_Phone = @Phone OR Member_Email = @Email) AND Member_Id != @ID";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                            checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            checkCmd.Parameters.AddWithValue("@ID", intID);

                            int duplicateCount = (int)checkCmd.ExecuteScalar(); // 取得符合條件的記錄數量

                            if (duplicateCount > 0)
                            {
                                MessageBox.Show("該手機號碼或電子郵件已被其他會員使用，請改用其他資料。");

                                return;
                            }

                        }

                        // 如果沒有重複資料，則進行更新
                        string updateQuery = "UPDATE Members SET Member_Name = @UpdateName, Member_Phone = @UpdatePhone, Member_Email = @UpdateEmail, " +
                                             "Member_Birthday = @UpdateBirthday WHERE Member_Id = @ID";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@ID", intID);
                            updateCmd.Parameters.AddWithValue("@UpdateName", txtName.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@UpdatePhone", txtPhone.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@UpdateEmail", txtEmail.Text.Trim());
                            updateCmd.Parameters.AddWithValue("@UpdateBirthday", DTbirthday.Value.ToString("yyyy-MM-dd"));

                            int rowsAffected = updateCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("會員資訊更新成功！");
                            }
                            else
                            {
                                MessageBox.Show("密碼錯誤，請重新輸入!");
                            }
                        }
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("資料不齊全，請填寫完整!");
            }
            SearchAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int intID = Convert.ToInt32(lbID.Text);

                if (intID > 1000)
                {
                    var result = MessageBox.Show($"是否刪除ID: {intID} 資料?", "刪除資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                        {
                            con.Open();
                            string strSQL = "DELETE FROM Members WHERE Member_id = @DeleteID;";
                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@DeleteID", intID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                ClearAll();
                                MessageBox.Show("資料刪除成功");                           
                            }
                            else
                            {
                                MessageBox.Show("查無此人可刪除!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("查無此人可刪除!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除失敗，錯誤訊息: {ex.Message}");
            }

            SearchAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.Trim();
            string Phone = txtPhone.Text.Trim();
            string Email= txtEmail.Text.Trim();
            if (Name == "") 
            {
                Name = "  ";
            }
            if (Phone == "") 
            {
                Phone = "  ";
            }
            if (Email=="") 
            {
                Email = "  ";
            }

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from Members where " +
                $"Member_Name like @Name or " +
                $"Member_Phone like @Phone or " +
                $"Member_Email like @Email ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Name", $"%{Name}%");
            cmd.Parameters.AddWithValue("@Phone", $"%{Phone}%");
            cmd.Parameters.AddWithValue("@Email", $"%{Email}%");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGV_count = dt.Rows.Count;
                DGVMembers.DataSource = dt;
            }
            else
            {
                MessageBox.Show("查無此人");
            }
            reader.Close();
            con.Close();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
