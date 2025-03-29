namespace GuitarShop
{
    partial class CartItemCheck
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
            this.lbPName = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbitemTotal = new System.Windows.Forms.Label();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.picproduct = new System.Windows.Forms.PictureBox();
            this.btnplus = new FontAwesome.Sharp.IconButton();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPName
            // 
            this.lbPName.AutoSize = true;
            this.lbPName.Font = new System.Drawing.Font("Noto Sans TC Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPName.Location = new System.Drawing.Point(94, 25);
            this.lbPName.Name = "lbPName";
            this.lbPName.Size = new System.Drawing.Size(74, 24);
            this.lbPName.TabIndex = 1;
            this.lbPName.Text = "商品名稱";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Font = new System.Drawing.Font("Noto Sans TC Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbUnitPrice.Location = new System.Drawing.Point(220, 25);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(42, 24);
            this.lbUnitPrice.TabIndex = 2;
            this.lbUnitPrice.Text = "單價";
            // 
            // lbitemTotal
            // 
            this.lbitemTotal.AutoSize = true;
            this.lbitemTotal.Font = new System.Drawing.Font("Noto Sans TC Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbitemTotal.Location = new System.Drawing.Point(522, 25);
            this.lbitemTotal.Name = "lbitemTotal";
            this.lbitemTotal.Size = new System.Drawing.Size(42, 24);
            this.lbitemTotal.TabIndex = 4;
            this.lbitemTotal.Text = "小計";
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.Color.Black;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 30;
            this.btnMinus.Location = new System.Drawing.Point(352, 25);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(27, 25);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // picproduct
            // 
            this.picproduct.Location = new System.Drawing.Point(3, 3);
            this.picproduct.Name = "picproduct";
            this.picproduct.Size = new System.Drawing.Size(70, 70);
            this.picproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picproduct.TabIndex = 0;
            this.picproduct.TabStop = false;
            // 
            // btnplus
            // 
            this.btnplus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnplus.IconColor = System.Drawing.Color.Black;
            this.btnplus.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnplus.IconSize = 30;
            this.btnplus.Location = new System.Drawing.Point(421, 25);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(27, 24);
            this.btnplus.TabIndex = 6;
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // txtNum
            // 
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(385, 25);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(30, 25);
            this.txtNum.TabIndex = 7;
            this.txtNum.Text = "1";
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRemove.IconSize = 25;
            this.btnRemove.Location = new System.Drawing.Point(587, 22);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 34);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // CartItemCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lbitemTotal);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbPName);
            this.Controls.Add(this.picproduct);
            this.Name = "CartItemCheck";
            this.Size = new System.Drawing.Size(630, 75);
            this.Load += new System.EventHandler(this.CartItemCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picproduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picproduct;
        public System.Windows.Forms.Label lbPName;
        public System.Windows.Forms.Label lbUnitPrice;
        public System.Windows.Forms.Label lbitemTotal;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnplus;
        public System.Windows.Forms.TextBox txtNum;
        private FontAwesome.Sharp.IconButton btnRemove;
    }
}
