namespace GuitarShop
{
    partial class MemberInfo
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
            this.panelbtn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignout = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelUpdatePwd = new System.Windows.Forms.Panel();
            this.lbupdatePwd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelUpdateInfo = new System.Windows.Forms.Panel();
            this.lbupdateInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.lbMyAccount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelbtn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelUpdatePwd.SuspendLayout();
            this.panelUpdateInfo.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.Color.White;
            this.panelbtn.Controls.Add(this.panel2);
            this.panelbtn.Controls.Add(this.panelOrder);
            this.panelbtn.Controls.Add(this.panelUpdatePwd);
            this.panelbtn.Controls.Add(this.panelUpdateInfo);
            this.panelbtn.Controls.Add(this.panelAccount);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelbtn.Location = new System.Drawing.Point(0, 0);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(200, 500);
            this.panelbtn.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSignout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 60);
            this.panel2.TabIndex = 7;
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.Transparent;
            this.btnSignout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSignout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnSignout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSignout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSignout.IconSize = 40;
            this.btnSignout.Location = new System.Drawing.Point(0, 2);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(200, 57);
            this.btnSignout.TabIndex = 8;
            this.btnSignout.Text = " 登出";
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 1);
            this.label1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 2);
            this.label5.TabIndex = 1;
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.label9);
            this.panelOrder.Controls.Add(this.lbOrder);
            this.panelOrder.Controls.Add(this.label8);
            this.panelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrder.Location = new System.Drawing.Point(0, 216);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(200, 72);
            this.panelOrder.TabIndex = 6;
            this.panelOrder.MouseEnter += new System.EventHandler(this.panelOrder_MouseEnter);
            this.panelOrder.MouseLeave += new System.EventHandler(this.panelOrder_MouseLeave);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(0, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 1);
            this.label9.TabIndex = 7;
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOrder.Location = new System.Drawing.Point(45, 18);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(111, 35);
            this.lbOrder.TabIndex = 2;
            this.lbOrder.Text = "訂單查詢";
            this.lbOrder.MouseEnter += new System.EventHandler(this.lbOrder_MouseEnter);
            this.lbOrder.MouseLeave += new System.EventHandler(this.lbOrder_MouseLeave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 2);
            this.label8.TabIndex = 1;
            // 
            // panelUpdatePwd
            // 
            this.panelUpdatePwd.Controls.Add(this.lbupdatePwd);
            this.panelUpdatePwd.Controls.Add(this.label6);
            this.panelUpdatePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUpdatePwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdatePwd.Location = new System.Drawing.Point(0, 144);
            this.panelUpdatePwd.Name = "panelUpdatePwd";
            this.panelUpdatePwd.Size = new System.Drawing.Size(200, 72);
            this.panelUpdatePwd.TabIndex = 5;
            this.panelUpdatePwd.Click += new System.EventHandler(this.panelUpdatePwd_Click);
            this.panelUpdatePwd.MouseEnter += new System.EventHandler(this.panelUpdatePwd_MouseEnter);
            this.panelUpdatePwd.MouseLeave += new System.EventHandler(this.panelUpdatePwd_MouseLeave);
            // 
            // lbupdatePwd
            // 
            this.lbupdatePwd.AutoSize = true;
            this.lbupdatePwd.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbupdatePwd.Location = new System.Drawing.Point(45, 18);
            this.lbupdatePwd.Name = "lbupdatePwd";
            this.lbupdatePwd.Size = new System.Drawing.Size(111, 35);
            this.lbupdatePwd.TabIndex = 2;
            this.lbupdatePwd.Text = "更改密碼";
            this.lbupdatePwd.Click += new System.EventHandler(this.lbupdatePwd_Click);
            this.lbupdatePwd.MouseEnter += new System.EventHandler(this.lbupdatePwd_MouseEnter);
            this.lbupdatePwd.MouseLeave += new System.EventHandler(this.lbupdatePwd_MouseLeave);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 2);
            this.label6.TabIndex = 1;
            // 
            // panelUpdateInfo
            // 
            this.panelUpdateInfo.Controls.Add(this.lbupdateInfo);
            this.panelUpdateInfo.Controls.Add(this.label4);
            this.panelUpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelUpdateInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpdateInfo.Location = new System.Drawing.Point(0, 72);
            this.panelUpdateInfo.Name = "panelUpdateInfo";
            this.panelUpdateInfo.Size = new System.Drawing.Size(200, 72);
            this.panelUpdateInfo.TabIndex = 4;
            this.panelUpdateInfo.Click += new System.EventHandler(this.panelUpdateInfo_Click);
            this.panelUpdateInfo.MouseEnter += new System.EventHandler(this.panelUpdateInfo_MouseEnter);
            this.panelUpdateInfo.MouseLeave += new System.EventHandler(this.panelUpdateInfo_MouseLeave);
            // 
            // lbupdateInfo
            // 
            this.lbupdateInfo.AutoSize = true;
            this.lbupdateInfo.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbupdateInfo.Location = new System.Drawing.Point(20, 18);
            this.lbupdateInfo.Name = "lbupdateInfo";
            this.lbupdateInfo.Size = new System.Drawing.Size(159, 35);
            this.lbupdateInfo.TabIndex = 2;
            this.lbupdateInfo.Text = "更新個人資訊";
            this.lbupdateInfo.Click += new System.EventHandler(this.lbupdateInfo_Click);
            this.lbupdateInfo.MouseEnter += new System.EventHandler(this.lbupdateInfo_MouseEnter);
            this.lbupdateInfo.MouseLeave += new System.EventHandler(this.lbupdateInfo_MouseLeave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 2);
            this.label4.TabIndex = 1;
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.lbMyAccount);
            this.panelAccount.Controls.Add(this.label3);
            this.panelAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(200, 72);
            this.panelAccount.TabIndex = 3;
            this.panelAccount.Click += new System.EventHandler(this.panelAccount_Click);
            this.panelAccount.MouseEnter += new System.EventHandler(this.panelAccount_MouseEnter);
            this.panelAccount.MouseLeave += new System.EventHandler(this.panelAccount_MouseLeave_1);
            // 
            // lbMyAccount
            // 
            this.lbMyAccount.AutoSize = true;
            this.lbMyAccount.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbMyAccount.Location = new System.Drawing.Point(45, 18);
            this.lbMyAccount.Name = "lbMyAccount";
            this.lbMyAccount.Size = new System.Drawing.Size(111, 35);
            this.lbMyAccount.TabIndex = 2;
            this.lbMyAccount.Text = "我的帳戶";
            this.lbMyAccount.Click += new System.EventHandler(this.lbMyAccount_Click);
            this.lbMyAccount.MouseEnter += new System.EventHandler(this.lbMyAccount_MouseEnter);
            this.lbMyAccount.MouseLeave += new System.EventHandler(this.lbMyAccount_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 2);
            this.label3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(870, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 500);
            this.panel1.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(200, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(670, 500);
            this.panelInfo.TabIndex = 2;
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelbtn);
            this.Name = "MemberInfo";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.MemberInfo_Load);
            this.panelbtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.panelUpdatePwd.ResumeLayout(false);
            this.panelUpdatePwd.PerformLayout();
            this.panelUpdateInfo.ResumeLayout(false);
            this.panelUpdateInfo.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelbtn;
        public System.Windows.Forms.Panel panelOrder;
        public System.Windows.Forms.Label lbOrder;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panelUpdatePwd;
        public System.Windows.Forms.Label lbupdatePwd;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Panel panelUpdateInfo;
        public System.Windows.Forms.Label lbupdateInfo;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panelAccount;
        public System.Windows.Forms.Label lbMyAccount;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelInfo;
        public System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSignout;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label5;
    }
}
