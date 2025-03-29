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
    public partial class CartItemCheck : UserControl
    {
        public int CartID { set; get; }
        public int productID { set; get; }
        public EventHandler QuantityChanged;

        public CartItemCheck()
        {
            InitializeComponent();
        }

        private void CartItemCheck_Load(object sender, EventArgs e)
        {

        }              

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text) ;
            txtNum.Text = (num-1).ToString() ;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            txtNum.Text = (num + 1).ToString();           
           
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (GlobalVar.ShoppingCart.Count > 0)
            {
                int newQuantity = Convert.ToInt32(txtNum.Text);
                var item = GlobalVar.ShoppingCart[CartID];
                int MaxStocks = Convert.ToInt32(item[6]);

                if (newQuantity <= 0)
                {
                    var result = MessageBox.Show("確定移除商品?", "移除商品",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // 從購物車列表中刪除該項目
                        GlobalVar.ShoppingCart.Remove(CartID);
                        // 取得父表單
                        CheckoutForm checkoutForm = (CheckoutForm)this.FindForm();
                        // 更新購物車顯示的數量
                        checkoutForm.lbCartNum.Text = $"購物車內合計有 {GlobalVar.ShoppingCart.Count.ToString()} 項商品";
                        // 刪除該項目的控制項
                        this.Parent.Controls.Remove(this);
                        this.Dispose();
                        QuantityChanged?.Invoke(this, EventArgs.Empty);
                        return; // 添加return避免後續代碼執行

                    }
                    newQuantity = 1;
                    txtNum.Text = newQuantity.ToString();
                }
                // 取得當前數量值
                else if (newQuantity > MaxStocks)
                {
                    newQuantity = MaxStocks;
                    txtNum.Text = MaxStocks.ToString();
                    MessageBox.Show("超過庫存");
                }
                else
                { //修改GlobalVar.ShoppingCart裡的值
                    item[3] = newQuantity;
                    item[5] = newQuantity * Convert.ToInt32(item[2]);
                    QuantityChanged?.Invoke(this, EventArgs.Empty);
                }
                
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 從購物車列表中刪除該項目
            GlobalVar.ShoppingCart.Remove(CartID);
            // 取得父表單
            CheckoutForm checkoutForm = (CheckoutForm)this.FindForm();
            // 更新購物車顯示的數量
            checkoutForm.lbCartNum.Text = $"購物車內合計有 {GlobalVar.ShoppingCart.Count.ToString()} 項商品";
            // 刪除該項目的控制項
            this.Parent.Controls.Remove(this);
            this.Dispose();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
