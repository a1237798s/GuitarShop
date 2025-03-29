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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GuitarShop
{
    public partial class LoginControl : UserControl
    {
        public event EventHandler ShowRegister;
        public event EventHandler ShowProudcts;
        public event EventHandler ShowMemberInfo;
        public event EventHandler ClosePanelLeft;
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();

        public LoginControl()
        {
            InitializeComponent();

            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            string strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Clear();
            // 當點擊註冊按鈕時，觸發 ShowRegister 事件
            ShowRegister?.Invoke(this, EventArgs.Empty);
        }

        //登入驗證
        private Tuple<int, string, string, string> LoginValidator(string account, string password)
        {
            
            int userId = -1;
            string userName = null;
            string userEmail = null;
            string userPhone = null;
           
            using (SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                connection.Open();
                string query = "SELECT Member_Id, Member_Name,Member_Email,Member_Phone FROM Members WHERE (Member_Email = @Account OR Member_Phone = @Account) AND Member_Passwords = @Password;";
                
                SqlCommand cmd = new SqlCommand(query,connection);         
                
                cmd.Parameters.AddWithValue("@Account", account);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    userId = (int)reader["Member_Id"]; // 取得使用者ID
                    userName = (string)reader["Member_Name"];   // 取得使用者名稱
                    userEmail = (string)reader["Member_Email"];
                    userPhone = (string)reader["Member_Phone"];
                }
                reader.Close();                
            }

            return Tuple.Create(userId, userName, userEmail, userPhone);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = txtLogin_Phone.Text.Trim();            
            string password = txt_Login_Password.Text;

            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入帳號和密碼");
                return;
            }
            else if (account != "" && password != "") 
            {
                SqlConnection connection = new SqlConnection(GlobalVar.strDBConnectionString);

                connection.Open();
                string query = "SELECT Member_Id, Member_Name,Member_Email,Member_Phone FROM Members WHERE (Member_Email = @Account OR Member_Phone = @Account) AND Member_Passwords = @Password;";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Account", account);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                int userId;
                string userName;
                string userEmail;
                string userPhone;
                if (reader.Read())
                {
                    userId = (int)reader["Member_Id"]; // 取得使用者ID
                    userName = (string)reader["Member_Name"];   // 取得使用者名稱
                    userEmail = (string)reader["Member_Email"];
                    userPhone = (string)reader["Member_Phone"];

                    if (userId > 1)
                    {
                        //登入成功
                        MessageBox.Show("登入成功！");
                        GlobalVar.Currently_UserID = userId;
                        GlobalVar.Currently_UserName = userName;
                        GlobalVar.Currently_UserPhone = userPhone;
                        GlobalVar.Currently_UserEmail = userEmail;
                        GlobalVar.isLogin = true;
                        txtLogin_Phone.Text = "";
                        txt_Login_Password.Text = "";
                        // 進入系統或跳轉到主頁面
                        ShowMemberInfo.Invoke(this, EventArgs.Empty);
                        ClosePanelLeft.Invoke(this, EventArgs.Empty);

                        return;
                    }
                    else if (userId==1) 
                    {
                        //登入成功
                        MessageBox.Show("登入成功！");
                        GlobalVar.Currently_UserID = userId;
                        GlobalVar.Currently_UserName = userName;
                        GlobalVar.Currently_UserPhone = userPhone;
                        GlobalVar.Currently_UserEmail = userEmail;
                        GlobalVar.isLogin = true;
                        GlobalVar.isAdmin = true;
                        txtLogin_Phone.Text = "";
                        txt_Login_Password.Text = "";
                        // 進入系統或跳轉到主頁面
                        ShowMemberInfo.Invoke(this, EventArgs.Empty);
                        ClosePanelLeft.Invoke(this, EventArgs.Empty);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("登入失敗，請檢查帳號和密碼");
                    }
                }
                else
                {
                    MessageBox.Show("登入失敗，請檢查帳號和密碼");
                }
                reader.Close();
            }
           
            Console.WriteLine($"{GlobalVar.isLogin} {GlobalVar.Currently_UserID} {GlobalVar.Currently_UserName} {GlobalVar.Currently_UserPhone} {GlobalVar.Currently_UserEmail}");
        }
    }
}
