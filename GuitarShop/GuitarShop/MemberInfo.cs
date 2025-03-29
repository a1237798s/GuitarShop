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

namespace GuitarShop
{
    public partial class MemberInfo : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        private UpdateInfoControl updateInfoControl;
        private Account account;
        private UpdatePwdControl updatePwdControl;
        public event EventHandler ShowProductsFromAccount;
        public MemberInfo()
        {
            InitializeComponent();
            account = new Account { Dock = DockStyle.Fill };
            updateInfoControl = new UpdateInfoControl { Dock = DockStyle.Fill };
            updatePwdControl = new UpdatePwdControl { Dock = DockStyle.Fill };
            account.ShowProudcts += (s, e) => ShowProductsFromAccount?.Invoke(this, e);
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            panelInfo.Controls.Clear();
            panelInfo.Controls.Add(account);

            /* 伺服器位置 */
            scsb.DataSource = @".";     //伺服器位置
            scsb.InitialCatalog = "GuitarShop"; //資料庫名稱
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
        }

       
        private void panelAccount_MouseEnter(object sender, EventArgs e)
        {
            lbMyAccount.ForeColor = Color.FromArgb(228, 172, 113);
        }

        private void panelAccount_MouseLeave_1(object sender, EventArgs e)
        {
            lbMyAccount.ForeColor = Color.Black;
        }

        private void lbMyAccount_MouseEnter(object sender, EventArgs e)
        {
            panelAccount_MouseEnter(sender, e);
        }

        private void lbMyAccount_MouseLeave(object sender, EventArgs e)
        {
            panelAccount_MouseLeave_1(sender, e);
        }

        private void panelUpdateInfo_MouseEnter(object sender, EventArgs e)
        {
            lbupdateInfo.ForeColor = Color.FromArgb(228, 172, 113);
        }

        private void panelUpdateInfo_MouseLeave(object sender, EventArgs e)
        {
            lbupdateInfo.ForeColor = Color.Black;
        }

        private void lbupdateInfo_MouseEnter(object sender, EventArgs e)
        {
            panelUpdateInfo_MouseEnter(sender, e);
        }

        private void lbupdateInfo_MouseLeave(object sender, EventArgs e)
        {
            panelUpdateInfo_MouseLeave(sender, e);
        }

        private void panelUpdatePwd_MouseEnter(object sender, EventArgs e)
        {
            lbupdatePwd.ForeColor = Color.FromArgb(228, 172, 113);
        }

        private void panelUpdatePwd_MouseLeave(object sender, EventArgs e)
        {
            lbupdatePwd.ForeColor = Color.Black;
        }

        private void lbupdatePwd_MouseEnter(object sender, EventArgs e)
        {
            panelUpdatePwd_MouseEnter(sender, e);
        }

        private void lbupdatePwd_MouseLeave(object sender, EventArgs e)
        {
            panelUpdatePwd_MouseLeave(sender, e);
        }

        private void panelOrder_MouseEnter(object sender, EventArgs e)
        {
            lbOrder.ForeColor = Color.FromArgb(228, 172, 113);
        }

        private void panelOrder_MouseLeave(object sender, EventArgs e)
        {
            lbOrder.ForeColor = Color.Black;
        }

        private void lbOrder_MouseEnter(object sender, EventArgs e)
        {
            panelOrder_MouseEnter(sender, e);
        }

        private void lbOrder_MouseLeave(object sender, EventArgs e)
        {
            panelOrder_MouseLeave(sender, e);
        }
        private void panelAccount_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Clear();
            panelInfo.Controls.Add(account);
        }

        private void lbMyAccount_Click(object sender, EventArgs e)
        {
            panelAccount_Click(sender, e);
        }

        private void panelUpdateInfo_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Clear();
            panelInfo.Controls.Add(updateInfoControl);
        }

        private void lbupdateInfo_Click(object sender, EventArgs e)
        {
            panelUpdateInfo_Click(sender, e);
        }

        private void panelUpdatePwd_Click(object sender, EventArgs e)
        {
            panelInfo.Controls.Clear();
            panelInfo.Controls.Add(updatePwdControl);
        }

        private void lbupdatePwd_Click(object sender, EventArgs e)
        {
            panelUpdatePwd_Click(sender, e);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("確定是否登出?", "登出",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ShowProductsFromAccount.Invoke(this, new EventArgs());
                GlobalVar.isLogin = false;
                GlobalVar.Currently_UserID = 0;
                GlobalVar.Currently_UserName = "訪客";
                GlobalVar.Currently_UserPhone = "";
                GlobalVar.Currently_UserEmail = "";
                panelInfo.Controls.Clear();
            }
            else { }
            Console.WriteLine($"{GlobalVar.isLogin} {GlobalVar.Currently_UserID} {GlobalVar.Currently_UserName} {GlobalVar.Currently_UserPhone} {GlobalVar.Currently_UserEmail}");

        }
    }
}
