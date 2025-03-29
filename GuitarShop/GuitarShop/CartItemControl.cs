using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuitarShop
{

    public partial class CartItemControl : UserControl
    {
        public event EventHandler QuantityChanged;
     
        public int CartID { get; set; }
        public int productID { get; set; }       

        public CartItemControl()
        {
            InitializeComponent();
        }
       

        private void btnCartTrash_Click(object sender, EventArgs e)
        {
            // 從購物車列表中刪除該項目
            GlobalVar.ShoppingCart.Remove(CartID);

            // 取得父表單
            ProductsForm parentForm = (ProductsForm)this.FindForm();

            // 更新購物車顯示的數量
            parentForm.lbCartNum.Text = GlobalVar.ShoppingCart.Count.ToString();

            // 刪除該項目的控制項
            this.Parent.Controls.Remove(this);
            this.Dispose();

            // 若購物車為空，隱藏購物車面板
            if (GlobalVar.ShoppingCart.Count == 0)
            {
                parentForm.HideCartPanel();
            }
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CartItemControl_Load(object sender, EventArgs e)
        {

        }

        

        public void CartItemNum_ValueChanged(object sender, EventArgs e)
        {
            if (GlobalVar.ShoppingCart.Count > 0) 
            { 
                // 取得當前數量值
                int newQuantity = Convert.ToInt32(CartItemNum.Value);
                var item = GlobalVar.ShoppingCart[CartID];
                int MaxStocks = Convert.ToInt32(item[6]);
                ProductsForm parentForm = (ProductsForm)this.FindForm();

                if (newQuantity > MaxStocks)
                {
                    newQuantity = MaxStocks;
                    CartItemNum.Value = newQuantity; // 更新控制項顯示
                    MessageBox.Show("超過庫存");
                }
                else if (newQuantity > 0 && newQuantity < MaxStocks) 
                {
                    // 修改 GlobalVar.ShoppingCart 裡的值
                    item[3] = newQuantity;
                    item[5] = newQuantity * Convert.ToInt32(item[2]);

                    // 觸發數量改變的事件
                    QuantityChanged?.Invoke(this, EventArgs.Empty);
                }
                else if (newQuantity <= 0)
                {                  
                    newQuantity = 1;
                    CartItemNum.Value = newQuantity;
                }                
            }          
        }       
    }
}
