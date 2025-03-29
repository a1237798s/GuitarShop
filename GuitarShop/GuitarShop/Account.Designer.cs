namespace GuitarShop
{
    partial class Account
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccountSignout = new GuitarShop.RJButton();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAccountSignout);
            this.panel1.Controls.Add(this.lbPhone);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbOrder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(35, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAccountSignout
            // 
            this.btnAccountSignout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccountSignout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.btnAccountSignout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.btnAccountSignout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAccountSignout.BorderRadius = 15;
            this.btnAccountSignout.BorderSize = 0;
            this.btnAccountSignout.FlatAppearance.BorderSize = 0;
            this.btnAccountSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSignout.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccountSignout.ForeColor = System.Drawing.Color.Maroon;
            this.btnAccountSignout.Location = new System.Drawing.Point(448, 150);
            this.btnAccountSignout.Name = "btnAccountSignout";
            this.btnAccountSignout.Size = new System.Drawing.Size(104, 40);
            this.btnAccountSignout.TabIndex = 12;
            this.btnAccountSignout.Text = "登出";
            this.btnAccountSignout.TextColor = System.Drawing.Color.Maroon;
            this.btnAccountSignout.UseVisualStyleBackColor = false;
            this.btnAccountSignout.Click += new System.EventHandler(this.btnAccountSignout_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lbPhone.Location = new System.Drawing.Point(192, 92);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(63, 35);
            this.lbPhone.TabIndex = 11;
            this.lbPhone.Text = "電話";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lbEmail.Location = new System.Drawing.Point(192, 146);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(111, 35);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "電子郵件";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lbName.Location = new System.Drawing.Point(192, 38);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(63, 35);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "姓名";
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(183)))));
            this.lbOrder.Location = new System.Drawing.Point(59, 296);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(160, 30);
            this.lbOrder.TabIndex = 8;
            this.lbOrder.Text = "近期無任何訂單";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label3.Location = new System.Drawing.Point(62, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 5);
            this.label3.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(55, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 39);
            this.label16.TabIndex = 6;
            this.label16.Text = "電話";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(55, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 39);
            this.label17.TabIndex = 5;
            this.label17.Text = "電子郵件";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.lbTotal.Location = new System.Drawing.Point(487, 38);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(65, 30);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "NT$0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(186)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(342, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "累計消費金額";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Noto Sans TC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(54, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 46);
            this.label18.TabIndex = 1;
            this.label18.Text = "近期訂單";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(55, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 39);
            this.label15.TabIndex = 0;
            this.label15.Text = "姓名";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(670, 500);
            this.Load += new System.EventHandler(this.Account_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Account_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Account_ControlRemoved);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Account_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private RJButton btnAccountSignout;
    }
}
