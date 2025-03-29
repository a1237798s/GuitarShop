using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Drawing.Drawing2D;

namespace GuitarShop
{
    public partial class ProductCard : UserControl
    {
        public int productCardID { get; set; }
        public ProductCard()
        {
            InitializeComponent();
            pictureBoxProduct.Click += new EventHandler(ProductCard_Click);            
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            ShowProductDetails();            
        }
               

        private void ShowProductDetails()
        {
            // 觸發主表單上的事件，並傳遞 ProductID
            OnProductClicked?.Invoke(this, new ProductEventArgs(productCardID));            

            ProductDetails productDetails = new ProductDetails();
            productDetails.loadId = productCardID;  
          
            productDetails.ShowDialog();
        }

        public event EventHandler<ProductEventArgs> OnProductClicked;

        // 自訂事件參數類別，用於傳遞 ProductID
        public class ProductEventArgs : EventArgs
        {
            public int productCardID { get; }

            public ProductEventArgs(int Product_id)
            {
                productCardID = Product_id;                 
            }        
        }
                
    }
}
