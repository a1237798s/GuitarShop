using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarShop
{
    public class GlobalVar
    {
        public static string image_dir = @"C:\Users\raite\OneDrive\桌面\GuitarShop\Photos\products\";
        public static string strDBConnectionString = "";
        public static Dictionary<int,ArrayList> ShoppingCart = new Dictionary<int,ArrayList>();
        public static int Currently_UserID = 0;
        public static string Currently_UserName = "訪客";
        public static string Currently_UserEmail = null;
        public static string Currently_UserPhone = null;
        public static bool isLogin = false;  //確認是否登入
        public static bool isAdmin = false;  //確認管理者登入
    }
}
