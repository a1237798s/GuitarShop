using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarShop
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /* 顯示會員管理視窗 */
        private void ShowMemberManagement()
        {
            ManageMember memberForm = new ManageMember();
            memberForm.ShowDialog();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (GlobalVar.isAdmin)
            {
                ShowMemberManagement();
            }
            else
            {
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                adminLogin.LoginSuccess += (s, ev) => ShowMemberManagement(); // 訂閱事件顯示會員管理視窗  
            }

        }





        private void btnproducts_Click(object sender, EventArgs e)
        {
            ProductsForm ProductsForm = new ProductsForm();
            ProductsForm.ShowDialog();
        }

        /* 顯示訂單查詢畫面 */
        private void ShowOrderQuery()
        {
            OrderList orderList = new OrderList();
            orderList.ShowDialog();
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            if (GlobalVar.isAdmin)
            {
                ShowOrderQuery();
            }
            else
            {
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                adminLogin.LoginSuccess += (s, ev) => ShowOrderQuery(); // 訂閱事件顯示   
            }
        }

        private void picMain1_Click(object sender, EventArgs e)
        {
            picMain.Image = picMain1.Image;
        }

        private void picMain2_Click(object sender, EventArgs e)
        {
            picMain.Image = picMain2.Image;
        }

        private void picMain3_Click(object sender, EventArgs e)
        {
            picMain.Image = picMain3.Image;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (GlobalVar.isAdmin)
            {
                MessageBox.Show("已登入成功!");
            }
            else
            {
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
               
            }

        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            if (GlobalVar.isAdmin)
            {
                GlobalVar.Currently_UserID = 0;
                GlobalVar.Currently_UserName = "訪客";
                GlobalVar.Currently_UserEmail = null;
                GlobalVar.Currently_UserPhone = null;
                GlobalVar.isLogin = false;
                GlobalVar.isAdmin = false;
                MessageBox.Show("已登出!");
            }
            else
            {
                MessageBox.Show("尚未登入!");
               
            }
        }
    }
}
