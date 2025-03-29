using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GuitarShop
{
    public partial class UpdatePwdControl : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public UpdatePwdControl()
        {
            InitializeComponent();
        }

        private void UpdatePwdControl_Load(object sender, EventArgs e)
        {
            CleanAll();
            /* 伺服器位置 */
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
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

        void UpdatePwd()
        {
            if (txtCurrentlyPwd.Text != "" && txtNewPwd.Text != "" && txtConfirmPwd.Text != "")
            {
                if (txtNewPwd.Text.Trim() != txtConfirmPwd.Text.Trim())
                {
                    MessageBox.Show("輸入的二次密碼不相符，請修正完後再按一次按鈕");
                    CleanAll();  // 清除文本框
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                    {
                        con.Open();

                        // 查詢當前密碼是否正確
                        string query = "SELECT COUNT(*) FROM Members WHERE Member_Id = @ID AND Member_Passwords = @Password";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);
                            cmd.Parameters.AddWithValue("@Password", txtCurrentlyPwd.Text.Trim());

                            // 使用 ExecuteScalar() 取得行數（返回的是記錄數量）
                            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (rowCount > 0)
                            {
                                // 如果當前密碼正確，更新密碼
                                string updateQuery = "UPDATE Members SET Member_Passwords = @NewPassword WHERE Member_Id = @ID";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                {
                                    updateCmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);
                                    updateCmd.Parameters.AddWithValue("@NewPassword", txtNewPwd.Text.Trim());

                                    // 執行更新
                                    updateCmd.ExecuteNonQuery();
                                    MessageBox.Show("密碼更改成功!!");
                                }
                                CleanAll();
                            }
                            else
                            {
                                MessageBox.Show("密碼錯誤!!");
                                CleanAll();  // 清除文本框
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("欄位不得為空值!!");
            }
        }

        //void UpdatePwd()
        //{
        //    if (txtCurrentlyPwd.Text != "" && txtNewPwd.Text != "" && txtConfirmPwd.Text != "")
        //    {
        //        if (txtNewPwd.Text.Trim() != txtConfirmPwd.Text.Trim()) 
        //        {
        //            MessageBox.Show("輸入的二次密碼不相符，請修正完後再按一次按鈕");
        //            CleanAll();
        //        }
        //        else 
        //        { 
        //            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
        //            {
        //                con.Open();

        //                string Query = "select Member_Passwords from Members WHERE Member_Id = @ID AND Member_Passwords = @Password";
        //                using (SqlCommand cmd = new SqlCommand(Query, con))
        //                {
        //                    cmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);
        //                    cmd.Parameters.AddWithValue("@Password", txtCurrentlyPwd.Text.Trim());
        //                    int row = (int)cmd.ExecuteScalar();  //回傳有幾筆數列

        //                    if (row == 1)
        //                    {
        //                        string updateQuery = "UPDATE Members SET Member_Passwords = @NewPassword WHERE Member_Id = @ID";
        //                        using (SqlCommand upadatecmd = new SqlCommand(updateQuery, con))
        //                        {
        //                            upadatecmd.Parameters.AddWithValue("@ID", GlobalVar.Currently_UserID);
        //                            upadatecmd.Parameters.AddWithValue("@Password", txtCurrentlyPwd.Text.Trim());

        //                            upadatecmd.ExecuteNonQuery();
        //                            MessageBox.Show("密碼更改成功!!");
        //                        }
        //                    }
        //                    else 
        //                    {
        //                        MessageBox.Show("密碼錯誤!!");
        //                        CleanAll();
        //                    }
        //                }

        //            }
        //        }
        //    }
        //    else 
        //    {
        //        MessageBox.Show("欄位不得為空值!!");
        //    }
        //}

        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdatePwd();
        }

        void CleanAll() 
        {
            txtCurrentlyPwd.Text = "";
            txtNewPwd.Text = "";
            txtConfirmPwd.Text = "";
        }

        private void btnClearn_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
    }
}
