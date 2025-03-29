using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShop
{
    public partial class RegisterControl : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public event EventHandler ShowLogin;
        public RegisterControl()
        {
            InitializeComponent();           
        }

        private void RegisterControl_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();           
        }

        //新增會員
        void RegisterMember()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            try
            {
                con.Open();
                string Query = "INSERT INTO Members(Member_Name,Member_Phone,Member_Email,Member_Birthday,Member_Passwords) VALUES(@NewName,@NewPhone,@NewEmail,@NewBirthday,@NewPasswords);";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@NewName", txtRegister_Name.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtReigister_Phone.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtRegister_Email.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", txt_Register_birthday.Value);
                cmd.Parameters.AddWithValue("@NewPasswords", txtReigister_Password.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("註冊失敗：" + ex.Message);
            }
            finally
            {
                con.Close(); // 關閉資料庫連線
            }
        }

        //確認會員電話,email是否重複
        void isRegister() 
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string Query = "select Member_Phone,Member_Email from Members;";
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                string M_Phone = reader["Member_Phone"].ToString();
                string M_Email = reader["Member_Email"].ToString();

                if (M_Phone == txtReigister_Phone.Text)
                {
                    MessageBox.Show("電話已經有人使用");
                    txtReigister_Phone.Text = "";
                }
                else if (M_Email == txtRegister_Email.Text)
                {
                    MessageBox.Show("Email已經有人使用");
                    txtRegister_Email.Text = "";
                }
              
            }
            reader.Close();
            con.Close();            
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

        private void btnSubmitReigister_Click(object sender, EventArgs e)
        {       
            if (txtRegister_Name.Text != "" && txtRegister_Email.Text != "" && txtReigister_Phone.Text != "" && txtReigister_Password.Text != "" &&
                txt_Reigister_PwdCheck.Text != "")
            {
                if (txtReigister_Password.Text.Trim() == txt_Reigister_PwdCheck.Text.Trim()) 
                {                    
                    RegisterMember();
                    MessageBox.Show("會員註冊成功!");                    
                    ShowLogin?.Invoke(this, EventArgs.Empty);                   
                }
                else { MessageBox.Show("輸入的二次密碼不相符，請修正完後再按一次按鈕"); }
            }
            else
            {
                MessageBox.Show("資料不齊全");
            }
        }

        private void txt_Register_birthday_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtReigister_Phone_Leave(object sender, EventArgs e)
        {
            // 檢查手機跟Email格式
            if (!IsValidPhoneNumber(txtReigister_Phone.Text))
            {
                MessageBox.Show("請輸入有效的手機號碼");
                return;
            }
            isRegister();
        }

       

        private void txtRegister_Email_Leave(object sender, EventArgs e)
        {
            // 檢查手機跟Email格式
            if (!IsValidEmail(txtRegister_Email.Text))
            {
                MessageBox.Show("請輸入有效電子郵件地址");
                return;
            }
            isRegister();
        }
    }
}
