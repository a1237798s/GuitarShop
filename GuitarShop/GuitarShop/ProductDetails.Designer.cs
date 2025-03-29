namespace GuitarShop
{
    partial class ProductDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDiscountPrice = new System.Windows.Forms.Label();
            this.lbInventory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNums = new System.Windows.Forms.NumericUpDown();
            this.btnAddshopcart = new GuitarShop.RJButton();
            this.btnPay = new GuitarShop.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbProductDescription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbProductName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.FLPimage = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNums)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbDiscountPrice);
            this.panel2.Controls.Add(this.lbInventory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNums);
            this.panel2.Controls.Add(this.btnAddshopcart);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(645, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 579);
            this.panel2.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.lbPrice.Location = new System.Drawing.Point(166, 453);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(53, 30);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "NT$";
            // 
            // lbDiscountPrice
            // 
            this.lbDiscountPrice.AutoSize = true;
            this.lbDiscountPrice.Font = new System.Drawing.Font("Noto Sans TC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDiscountPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDiscountPrice.Location = new System.Drawing.Point(9, 441);
            this.lbDiscountPrice.Name = "lbDiscountPrice";
            this.lbDiscountPrice.Size = new System.Drawing.Size(75, 42);
            this.lbDiscountPrice.TabIndex = 9;
            this.lbDiscountPrice.Text = "NT$";
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbInventory.Location = new System.Drawing.Point(182, 494);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(58, 24);
            this.lbInventory.TabIndex = 8;
            this.lbInventory.Text = "庫存：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(14, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "數量";
            // 
            // txtNums
            // 
            this.txtNums.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNums.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtNums.Location = new System.Drawing.Point(71, 487);
            this.txtNums.Name = "txtNums";
            this.txtNums.Size = new System.Drawing.Size(105, 33);
            this.txtNums.TabIndex = 6;
            this.txtNums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNums.ValueChanged += new System.EventHandler(this.txtNums_ValueChanged);
            // 
            // btnAddshopcart
            // 
            this.btnAddshopcart.BackColor = System.Drawing.Color.White;
            this.btnAddshopcart.BackgroundColor = System.Drawing.Color.White;
            this.btnAddshopcart.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddshopcart.BorderRadius = 0;
            this.btnAddshopcart.BorderSize = 0;
            this.btnAddshopcart.FlatAppearance.BorderSize = 0;
            this.btnAddshopcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddshopcart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddshopcart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddshopcart.Location = new System.Drawing.Point(16, 529);
            this.btnAddshopcart.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddshopcart.Name = "btnAddshopcart";
            this.btnAddshopcart.Size = new System.Drawing.Size(118, 41);
            this.btnAddshopcart.TabIndex = 5;
            this.btnAddshopcart.Text = "加入購物車";
            this.btnAddshopcart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAddshopcart.UseVisualStyleBackColor = false;
            this.btnAddshopcart.Click += new System.EventHandler(this.btnAddshopcart_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.btnPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(222)))));
            this.btnPay.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPay.BorderRadius = 0;
            this.btnPay.BorderSize = 0;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPay.Location = new System.Drawing.Point(149, 529);
            this.btnPay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(118, 41);
            this.btnPay.TabIndex = 4;
            this.btnPay.Text = "立即購買";
            this.btnPay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbProductDescription);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 236);
            this.panel4.TabIndex = 3;
            // 
            // lbProductDescription
            // 
            this.lbProductDescription.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbProductDescription.Location = new System.Drawing.Point(0, 0);
            this.lbProductDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lbProductDescription.Name = "lbProductDescription";
            this.lbProductDescription.Size = new System.Drawing.Size(281, 236);
            this.lbProductDescription.TabIndex = 1;
            this.lbProductDescription.Text = "商品描述";
            this.lbProductDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbProductName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 107);
            this.panel3.TabIndex = 2;
            // 
            // lbProductName
            // 
            this.lbProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProductName.Font = new System.Drawing.Font("Noto Sans TC Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lbProductName.Location = new System.Drawing.Point(0, 0);
            this.lbProductName.Margin = new System.Windows.Forms.Padding(0);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(281, 107);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "商品名稱";
            this.lbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 119);
            this.panel1.TabIndex = 2;
            // 
            // picMain
            // 
            this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picMain.Location = new System.Drawing.Point(209, 22);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(397, 418);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 3;
            this.picMain.TabStop = false;
            // 
            // FLPimage
            // 
            this.FLPimage.AutoScroll = true;
            this.FLPimage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLPimage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FLPimage.Location = new System.Drawing.Point(25, 22);
            this.FLPimage.Name = "FLPimage";
            this.FLPimage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FLPimage.Size = new System.Drawing.Size(160, 418);
            this.FLPimage.TabIndex = 4;
            this.FLPimage.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 460);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 129);
            this.panel6.TabIndex = 0;
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 579);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.FLPimage);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.Load += new System.EventHandler(this.ProductDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNums)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductDescription;
        private System.Windows.Forms.Panel panel3;
        private RJButton btnPay;
        private System.Windows.Forms.Panel panel4;
        private RJButton btnAddshopcart;
        private System.Windows.Forms.NumericUpDown txtNums;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.Label lbDiscountPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.PictureBox picMain;
        public System.Windows.Forms.FlowLayoutPanel FLPimage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}