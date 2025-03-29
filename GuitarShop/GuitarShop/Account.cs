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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GuitarShop
{
    public partial class Account : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public event EventHandler ShowProudcts;

        public Account()
        {
            InitializeComponent();
        }


        private void Account_Load(object sender, EventArgs e)
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
            lbName.Text = "";
            lbPhone.Text = "";
            lbEmail.Text = "";
           SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ID",GlobalVar.Currently_UserID);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) 
            {
                lbName.Text = (string)reader["Member_Name"];
                lbPhone.Text = (string)reader["Member_Phone"];
                lbEmail.Text = (string)reader["Member_Email"];
            }
            reader.Close();
            con.Close();
        }

            private void Account_Paint(object sender, PaintEventArgs e)
        {
           
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

        private void btnAccountSignout_Click(object sender, EventArgs e)
        {
            if (GlobalVar.isLogin) 
            {
                var result = MessageBox.Show("確定是否登出?","登出",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result==DialogResult.Yes) 
                {
                    
                    ShowProudcts.Invoke(this, new EventArgs());
                    GlobalVar.isLogin = false;
                    GlobalVar.Currently_UserID = 0;
                    GlobalVar.Currently_UserName = "訪客";
                    GlobalVar.Currently_UserPhone = null;
                    GlobalVar.Currently_UserEmail = null;
                    
                }
                               
            }
            Console.WriteLine($"{GlobalVar.isLogin} {GlobalVar.Currently_UserID} {GlobalVar.Currently_UserName} {GlobalVar.Currently_UserPhone} {GlobalVar.Currently_UserEmail}");
        }

        private void Account_ControlAdded(object sender, ControlEventArgs e)
        {
            string Query = "SELECT * FROM Members WHERE Member_Id = @ID;";
            LoadMemberInfo(Query);
        }

        private void Account_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }
    }
}
