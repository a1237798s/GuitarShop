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
    public partial class OrderDetailsForm : Form
    {
        private int Id;
        public OrderDetailsForm(int OrderID)
        {
            InitializeComponent();
            Id = OrderID;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
            {
                con.Open();
                string query = "select Order_Id as '訂單編號',Product_Id as '商品編號',Product_Name as '商品名稱',Quantity as '數量',UnitPrice as '單價',\r\nTotalAmount as '訂單總價',CreatedDate as '訂單日期' from OrdersDetails Where Order_Id =@OrderID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@OrderID", Id);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable orderDetailsTable = new DataTable();
                    adapter.Fill(orderDetailsTable);

                    // 假設 DataGridViewOrderDetails 是顯示 OrderDetails 的 DataGridView
                    DGVorderdetail.DataSource = orderDetailsTable;
                }
            }
        }

        private void OrderDetailsForm_Activated(object sender, EventArgs e)
        {
            
        }
    }
}
