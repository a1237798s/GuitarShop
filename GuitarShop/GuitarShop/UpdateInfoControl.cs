using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuitarShop
{
    public partial class UpdateInfoControl : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        public UpdateInfoControl()
        {
            InitializeComponent();
        }

        private void UpdateInfoControl_Load(object sender, EventArgs e)
        {
            /* 伺服器位置 */
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            string Query = "SELECT * FROM Members WHERE Member_Id = @ID;";
            LoadMemberInfo(Query);
        }
         void LoadMemberInfo(string Query)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lbID.Text = reader["Member_Id"].ToString();
                txtName.Text = (string)reader["Member_Name"];
                txtPhone.Text = (string)reader["Member_Phone"];
                txtEmail.Text = (string)reader["Member_Email"];
                DTBirthday.Value = (DateTime)reader["Member_Birthday"];
            }
            reader.Close();
            con.Close();
        }
             
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(183, 186, 183);
            int borderWidth = 2;
            int cornerRadius = 20;  // 圓角的半徑

            // 建立圓角矩形路徑
            using (GraphicsPath path = new GraphicsPath())
            {
                // Panel 的寬和高
                int panelWidth = panel1.ClientSize.Width - borderWidth;
                int panelHeight = panel1.ClientSize.Height - borderWidth;

                // 畫出圓角矩形
                path.AddArc(new Rectangle(borderWidth, borderWidth, cornerRadius, cornerRadius), 180, 90);  // 左上角
                path.AddArc(new Rectangle(panelWidth - cornerRadius, borderWidth, cornerRadius, cornerRadius), 270, 90);  // 右上角
                path.AddArc(new Rectangle(panelWidth - cornerRadius, panelHeight - cornerRadius, cornerRadius, cornerRadius), 0, 90);  // 右下角
                path.AddArc(new Rectangle(borderWidth, panelHeight - cornerRadius, cornerRadius, cornerRadius), 90, 90);  // 左下角
                path.CloseFigure();

                // 畫出圓角框線
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }


        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.FromArgb(154, 158, 162);
            btnClear.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.ForeColor = Color.FromArgb(154, 158, 162);
        }

        private void btnConfirm_MouseEnter(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.White;
            btnConfirm.ForeColor = Color.FromArgb(195, 157, 111);
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.BackColor = Color.FromArgb(195, 157, 111);
            btnConfirm.ForeColor = Color.White;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text="";
            txtEmail.Text = "";
            DTBirthday.Value = DateTime.Now;
            txtPhone.Text = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {            
            updateMemberInfo();
        }


        //更新會員
        void updateMemberInfo()
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" )
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
                        checkCmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);

                        int duplicateCount = (int)checkCmd.ExecuteScalar(); // 取得符合條件的記錄數量

                        if (duplicateCount > 0)
                        {
                            MessageBox.Show("該手機號碼或電子郵件已被其他會員使用，請改用其他資料。");

                            return;
                        }

                    }

                    // 如果沒有重複資料，則進行更新
                    string updateQuery = "UPDATE Members SET Member_Name = @UpdateName, Member_Phone = @UpdatePhone, Member_Email = @UpdateEmail, " +
                                         "Member_Birthday = @UpdateBirthday WHERE Member_Id = @ID AND Member_Passwords = @Password";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);
                        updateCmd.Parameters.AddWithValue("@UpdateName", txtName.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@UpdatePhone", txtPhone.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@UpdateEmail", txtEmail.Text.Trim());
                        updateCmd.Parameters.AddWithValue("@UpdateBirthday", DTBirthday.Value.ToString("yyyy-MM-dd"));
                        updateCmd.Parameters.AddWithValue("@Password", txtPwd.Text.Trim());

                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("會員資訊更新成功！");
                            txtPwd.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("密碼錯誤，請重新輸入!");
                            txtPwd.Text = "";
                        }
                    }
                    conn.Close();
                }
            }
            else 
            {
                MessageBox.Show("資料不齊全，請填寫完整!");
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

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("請輸入有效電子郵件地址");
                return;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (!IsValidPhoneNumber(txtPhone.Text))
            {
                MessageBox.Show("請輸入有效的手機號碼");
                return;
            }
        }
    }
}
