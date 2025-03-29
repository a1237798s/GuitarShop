namespace GuitarShop
{
    partial class CartItemControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCartPname = new System.Windows.Forms.Label();
            this.lbCartUnitPrice = new System.Windows.Forms.Label();
            this.lbCartQuantity = new System.Windows.Forms.Label();
            this.picCart = new System.Windows.Forms.PictureBox();
            this.btnCartTrash = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CartItemNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCartItemTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartItemNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCartPname
            // 
            this.lbCartPname.AutoSize = true;
            this.lbCartPname.BackColor = System.Drawing.Color.Transparent;
            this.lbCartPname.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCartPname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lbCartPname.Location = new System.Drawing.Point(125, 5);
            this.lbCartPname.Name = "lbCartPname";
            this.lbCartPname.Size = new System.Drawing.Size(88, 27);
            this.lbCartPname.TabIndex = 1;
            this.lbCartPname.Text = "商品名稱";
            this.lbCartPname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCartUnitPrice
            // 
            this.lbCartUnitPrice.AutoSize = true;
            this.lbCartUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbCartUnitPrice.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCartUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCartUnitPrice.Location = new System.Drawing.Point(177, 77);
            this.lbCartUnitPrice.Name = "lbCartUnitPrice";
            this.lbCartUnitPrice.Size = new System.Drawing.Size(42, 24);
            this.lbCartUnitPrice.TabIndex = 2;
            this.lbCartUnitPrice.Text = "單價";
            this.lbCartUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCartQuantity
            // 
            this.lbCartQuantity.AutoSize = true;
            this.lbCartQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbCartQuantity.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCartQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lbCartQuantity.Location = new System.Drawing.Point(125, 39);
            this.lbCartQuantity.Name = "lbCartQuantity";
            this.lbCartQuantity.Size = new System.Drawing.Size(50, 27);
            this.lbCartQuantity.TabIndex = 3;
            this.lbCartQuantity.Text = "數量";
            this.lbCartQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picCart
            // 
            this.picCart.Location = new System.Drawing.Point(3, 3);
            this.picCart.Name = "picCart";
            this.picCart.Size = new System.Drawing.Size(120, 140);
            this.picCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCart.TabIndex = 0;
            this.picCart.TabStop = false;
            // 
            // btnCartTrash
            // 
            this.btnCartTrash.BackColor = System.Drawing.Color.Transparent;
            this.btnCartTrash.FlatAppearance.BorderSize = 0;
            this.btnCartTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartTrash.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCartTrash.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnCartTrash.IconColor = System.Drawing.Color.DimGray;
            this.btnCartTrash.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCartTrash.IconSize = 25;
            this.btnCartTrash.Location = new System.Drawing.Point(272, 112);
            this.btnCartTrash.Name = "btnCartTrash";
            this.btnCartTrash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCartTrash.Size = new System.Drawing.Size(28, 39);
            this.btnCartTrash.TabIndex = 4;
            this.btnCartTrash.UseVisualStyleBackColor = false;
            this.btnCartTrash.Click += new System.EventHandler(this.btnCartTrash_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 5);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(125, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "小計";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartItemNum
            // 
            this.CartItemNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CartItemNum.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CartItemNum.Location = new System.Drawing.Point(192, 42);
            this.CartItemNum.Name = "CartItemNum";
            this.CartItemNum.Size = new System.Drawing.Size(70, 27);
            this.CartItemNum.TabIndex = 7;
            this.CartItemNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CartItemNum.ValueChanged += new System.EventHandler(this.CartItemNum_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.label3.Location = new System.Drawing.Point(125, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "單價";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCartItemTotal
            // 
            this.lbCartItemTotal.AutoSize = true;
            this.lbCartItemTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbCartItemTotal.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCartItemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCartItemTotal.Location = new System.Drawing.Point(177, 112);
            this.lbCartItemTotal.Name = "lbCartItemTotal";
            this.lbCartItemTotal.Size = new System.Drawing.Size(42, 24);
            this.lbCartItemTotal.TabIndex = 9;
            this.lbCartItemTotal.Text = "小計";
            this.lbCartItemTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CartItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbCartItemTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CartItemNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCartTrash);
            this.Controls.Add(this.lbCartQuantity);
            this.Controls.Add(this.lbCartUnitPrice);
            this.Controls.Add(this.lbCartPname);
            this.Controls.Add(this.picCart);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartItemControl";
            this.Size = new System.Drawing.Size(300, 150);
            this.Load += new System.EventHandler(this.CartItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartItemNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picCart;
        public System.Windows.Forms.Label lbCartPname;
        public System.Windows.Forms.Label lbCartUnitPrice;
        public System.Windows.Forms.Label lbCartQuantity;
        public FontAwesome.Sharp.IconButton btnCartTrash;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown CartItemNum;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbCartItemTotal;
    }
}
