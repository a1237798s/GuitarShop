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

namespace GuitarShop
{
    public partial class AdminLogin : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public event EventHandler LoginSuccess;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void txtaccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtaccount.Text.Trim();
            string password = txtpassword.Text.Trim();
            if (account != "" && password != "")
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Members WHERE Member_id = 1 AND Member_Phone = @Account AND Member_Passwords = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Account", account);
                    cmd.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            GlobalVar.isLogin = true;
                            GlobalVar.Currently_UserName = "Admin";
                            GlobalVar.Currently_UserID = 1;
                            GlobalVar.Currently_UserPhone = "";
                            GlobalVar.Currently_UserEmail = "";
                            GlobalVar.isAdmin = true;
                            
                            MessageBox.Show("登入成功");

                            //登入成功關閉表單
                            
                            // 關閉登入畫面
                            this.Close();
                            LoginSuccess?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("帳密錯誤!!");
                        }
                    }
                }
            }
            else 
            {
                MessageBox.Show("帳密錯誤!!");
            }
            Console.WriteLine($"{GlobalVar.isLogin} {GlobalVar.Currently_UserID} {GlobalVar.Currently_UserName} {GlobalVar.Currently_UserPhone} {GlobalVar.Currently_UserEmail}");

        }
    }
}
