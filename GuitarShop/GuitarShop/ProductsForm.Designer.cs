namespace GuitarShop
{
    partial class ProductsForm
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Currently_User = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lbCartNum = new System.Windows.Forms.Label();
            this.ShopCart = new System.Windows.Forms.PictureBox();
            this.Member = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnProductManager = new GuitarShop.RJButton();
            this.btnEGfilter = new GuitarShop.RJButton();
            this.btnAGfilter = new GuitarShop.RJButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAll = new System.Windows.Forms.FlowLayoutPanel();
            this.cartItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.CartContainerPanel = new System.Windows.Forms.Panel();
            this.CartPayPanel = new System.Windows.Forms.Panel();
            this.lbCarttotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncheckout = new GuitarShop.RJButton();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Member)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.CartContainerPanel.SuspendLayout();
            this.CartPayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTop.Controls.Add(this.btnHome);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1064, 58);
            this.panelTop.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.Location = new System.Drawing.Point(12, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(43, 43);
            this.btnHome.TabIndex = 5;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Currently_User);
            this.panel1.Controls.Add(this.lblUsers);
            this.panel1.Controls.Add(this.lbCartNum);
            this.panel1.Controls.Add(this.ShopCart);
            this.panel1.Controls.Add(this.Member);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(805, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 58);
            this.panel1.TabIndex = 4;
            // 
            // Currently_User
            // 
            this.Currently_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Currently_User.AutoSize = true;
            this.Currently_User.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Currently_User.ForeColor = System.Drawing.Color.Navy;
            this.Currently_User.Location = new System.Drawing.Point(35, 23);
            this.Currently_User.Name = "Currently_User";
            this.Currently_User.Size = new System.Drawing.Size(69, 27);
            this.Currently_User.TabIndex = 5;
            this.Currently_User.Text = "使用者";
            this.Currently_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsers
            // 
            this.lblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUsers.Location = new System.Drawing.Point(35, 6);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(68, 17);
            this.lblUsers.TabIndex = 4;
            this.lblUsers.Text = "目前使用者";
            // 
            // lbCartNum
            // 
            this.lbCartNum.AutoSize = true;
            this.lbCartNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCartNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCartNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbCartNum.Location = new System.Drawing.Point(218, 22);
            this.lbCartNum.Name = "lbCartNum";
            this.lbCartNum.Size = new System.Drawing.Size(20, 21);
            this.lbCartNum.TabIndex = 0;
            this.lbCartNum.Text = "0";
            this.lbCartNum.Click += new System.EventHandler(this.lbCartNum_Click);
            // 
            // ShopCart
            // 
            this.ShopCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShopCart.Image = global::GuitarShop.Properties.Resources.shoppingbag;
            this.ShopCart.Location = new System.Drawing.Point(202, 2);
            this.ShopCart.Margin = new System.Windows.Forms.Padding(15, 7, 15, 5);
            this.ShopCart.Name = "ShopCart";
            this.ShopCart.Size = new System.Drawing.Size(50, 50);
            this.ShopCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShopCart.TabIndex = 3;
            this.ShopCart.TabStop = false;
            this.ShopCart.Click += new System.EventHandler(this.ShopCart_Click);
            // 
            // Member
            // 
            this.Member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Member.Image = global::GuitarShop.Properties.Resources.user;
            this.Member.Location = new System.Drawing.Point(138, 7);
            this.Member.Margin = new System.Windows.Forms.Padding(5, 7, 15, 5);
            this.Member.Name = "Member";
            this.Member.Size = new System.Drawing.Size(42, 42);
            this.Member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Member.TabIndex = 2;
            this.Member.TabStop = false;
            this.Member.Click += new System.EventHandler(this.Member_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.btnProductManager);
            this.panelLeft.Controls.Add(this.btnEGfilter);
            this.panelLeft.Controls.Add(this.btnAGfilter);
            this.panelLeft.Controls.Add(this.flowLayoutPanel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 58);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(5);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(150, 500);
            this.panelLeft.TabIndex = 1;
            // 
            // btnProductManager
            // 
            this.btnProductManager.BackColor = System.Drawing.Color.Transparent;
            this.btnProductManager.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnProductManager.BorderColor = System.Drawing.Color.Transparent;
            this.btnProductManager.BorderRadius = 0;
            this.btnProductManager.BorderSize = 0;
            this.btnProductManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProductManager.FlatAppearance.BorderSize = 0;
            this.btnProductManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManager.Font = new System.Drawing.Font("辰宇落雁體 Thin", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnProductManager.ForeColor = System.Drawing.Color.Firebrick;
            this.btnProductManager.Location = new System.Drawing.Point(5, 433);
            this.btnProductManager.Name = "btnProductManager";
            this.btnProductManager.Size = new System.Drawing.Size(140, 62);
            this.btnProductManager.TabIndex = 6;
            this.btnProductManager.TabStop = false;
            this.btnProductManager.Text = "商品管理";
            this.btnProductManager.TextColor = System.Drawing.Color.Firebrick;
            this.btnProductManager.UseVisualStyleBackColor = false;
            this.btnProductManager.Click += new System.EventHandler(this.btnProductManager_Click);
            // 
            // btnEGfilter
            // 
            this.btnEGfilter.BackColor = System.Drawing.Color.Transparent;
            this.btnEGfilter.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEGfilter.BorderColor = System.Drawing.Color.Transparent;
            this.btnEGfilter.BorderRadius = 0;
            this.btnEGfilter.BorderSize = 0;
            this.btnEGfilter.FlatAppearance.BorderSize = 0;
            this.btnEGfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEGfilter.Font = new System.Drawing.Font("辰宇落雁體 Thin", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEGfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEGfilter.Location = new System.Drawing.Point(0, 87);
            this.btnEGfilter.Name = "btnEGfilter";
            this.btnEGfilter.Size = new System.Drawing.Size(151, 87);
            this.btnEGfilter.TabIndex = 5;
            this.btnEGfilter.TabStop = false;
            this.btnEGfilter.Text = "電吉他";
            this.btnEGfilter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEGfilter.UseVisualStyleBackColor = false;
            this.btnEGfilter.Click += new System.EventHandler(this.btnEGfilter_Click);
            // 
            // btnAGfilter
            // 
            this.btnAGfilter.BackColor = System.Drawing.Color.Transparent;
            this.btnAGfilter.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAGfilter.BorderColor = System.Drawing.Color.Transparent;
            this.btnAGfilter.BorderRadius = 0;
            this.btnAGfilter.BorderSize = 0;
            this.btnAGfilter.FlatAppearance.BorderSize = 0;
            this.btnAGfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGfilter.Font = new System.Drawing.Font("辰宇落雁體 Thin", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAGfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAGfilter.Location = new System.Drawing.Point(0, 0);
            this.btnAGfilter.Name = "btnAGfilter";
            this.btnAGfilter.Size = new System.Drawing.Size(151, 87);
            this.btnAGfilter.TabIndex = 3;
            this.btnAGfilter.TabStop = false;
            this.btnAGfilter.Text = "木吉他";
            this.btnAGfilter.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAGfilter.UseVisualStyleBackColor = false;
            this.btnAGfilter.Click += new System.EventHandler(this.btnAGfilter_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(154, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(876, 497);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanelAll
            // 
            this.flowLayoutPanelAll.AutoScroll = true;
            this.flowLayoutPanelAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAll.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAll.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelAll.Name = "flowLayoutPanelAll";
            this.flowLayoutPanelAll.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelAll.Size = new System.Drawing.Size(914, 500);
            this.flowLayoutPanelAll.TabIndex = 1;
            // 
            // cartItemPanel
            // 
            this.cartItemPanel.AutoScroll = true;
            this.cartItemPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cartItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cartItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartItemPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.cartItemPanel.Location = new System.Drawing.Point(0, 0);
            this.cartItemPanel.MinimumSize = new System.Drawing.Size(300, 0);
            this.cartItemPanel.Name = "cartItemPanel";
            this.cartItemPanel.Size = new System.Drawing.Size(300, 451);
            this.cartItemPanel.TabIndex = 2;
            this.cartItemPanel.WrapContents = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.CartContainerPanel);
            this.panelContainer.Controls.Add(this.flowLayoutPanelAll);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(150, 58);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(914, 500);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelContainer_ControlAdded);
            this.panelContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelContainer_ControlRemoved);
            // 
            // CartContainerPanel
            // 
            this.CartContainerPanel.Controls.Add(this.cartItemPanel);
            this.CartContainerPanel.Controls.Add(this.CartPayPanel);
            this.CartContainerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CartContainerPanel.Location = new System.Drawing.Point(914, 0);
            this.CartContainerPanel.Name = "CartContainerPanel";
            this.CartContainerPanel.Size = new System.Drawing.Size(0, 500);
            this.CartContainerPanel.TabIndex = 2;
            // 
            // CartPayPanel
            // 
            this.CartPayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CartPayPanel.Controls.Add(this.lbCarttotal);
            this.CartPayPanel.Controls.Add(this.label1);
            this.CartPayPanel.Controls.Add(this.btncheckout);
            this.CartPayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CartPayPanel.Location = new System.Drawing.Point(0, 451);
            this.CartPayPanel.Name = "CartPayPanel";
            this.CartPayPanel.Size = new System.Drawing.Size(0, 49);
            this.CartPayPanel.TabIndex = 0;
            // 
            // lbCarttotal
            // 
            this.lbCarttotal.AutoSize = true;
            this.lbCarttotal.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCarttotal.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCarttotal.Location = new System.Drawing.Point(58, 9);
            this.lbCarttotal.Name = "lbCarttotal";
            this.lbCarttotal.Size = new System.Drawing.Size(55, 30);
            this.lbCarttotal.TabIndex = 2;
            this.lbCarttotal.Text = "總價";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "總價:";
            // 
            // btncheckout
            // 
            this.btncheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.btncheckout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.btncheckout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncheckout.BorderRadius = 10;
            this.btncheckout.BorderSize = 0;
            this.btncheckout.FlatAppearance.BorderSize = 0;
            this.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheckout.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncheckout.ForeColor = System.Drawing.Color.White;
            this.btncheckout.Location = new System.Drawing.Point(185, 6);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(120, 35);
            this.btncheckout.TabIndex = 0;
            this.btncheckout.Text = "立即結帳";
            this.btncheckout.TextColor = System.Drawing.Color.White;
            this.btncheckout.UseVisualStyleBackColor = false;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 558);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Name = "ProductsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ProductsForm";
            this.Activated += new System.EventHandler(this.ProductsForm_Activated);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Member)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.CartContainerPanel.ResumeLayout(false);
            this.CartPayPanel.ResumeLayout(false);
            this.CartPayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel cartItemPanel;
        public System.Windows.Forms.Label lbCartNum;
        public System.Windows.Forms.Label Currently_User;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAll;
        public System.Windows.Forms.Label lbCarttotal;
        private System.Windows.Forms.PictureBox Member;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RJButton btnAGfilter;
        private RJButton btnEGfilter;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lblUsers;
        private FontAwesome.Sharp.IconButton btnHome;
        private RJButton btncheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CartPayPanel;
        public System.Windows.Forms.PictureBox ShopCart;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel CartContainerPanel;
        public System.Windows.Forms.Panel panelTop;
        private RJButton btnProductManager;
    }
}