namespace GuitarShop
{
    partial class UpdatePwdControl
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
            this.txtCurrentlyPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModify = new GuitarShop.RJButton();
            this.btnClearn = new GuitarShop.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.txtCurrentlyPwd);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnClearn);
            this.panel1.Controls.Add(this.txtNewPwd);
            this.panel1.Controls.Add(this.txtConfirmPwd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(35, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCurrentlyPwd
            // 
            this.txtCurrentlyPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentlyPwd.BackColor = System.Drawing.Color.MistyRose;
            this.txtCurrentlyPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentlyPwd.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentlyPwd.Location = new System.Drawing.Point(275, 104);
            this.txtCurrentlyPwd.MaxLength = 50;
            this.txtCurrentlyPwd.Name = "txtCurrentlyPwd";
            this.txtCurrentlyPwd.PasswordChar = '*';
            this.txtCurrentlyPwd.Size = new System.Drawing.Size(186, 27);
            this.txtCurrentlyPwd.TabIndex = 15;
            this.txtCurrentlyPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPwd.BackColor = System.Drawing.Color.MistyRose;
            this.txtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPwd.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNewPwd.Location = new System.Drawing.Point(275, 164);
            this.txtNewPwd.MaxLength = 50;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(186, 27);
            this.txtNewPwd.TabIndex = 16;
            this.txtNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPwd.BackColor = System.Drawing.Color.MistyRose;
            this.txtConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPwd.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtConfirmPwd.Location = new System.Drawing.Point(275, 224);
            this.txtConfirmPwd.MaxLength = 50;
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(186, 27);
            this.txtConfirmPwd.TabIndex = 17;
            this.txtConfirmPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(123, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "目前密碼";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(123, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "新密碼";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(123, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "新密碼確認";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.btnModify.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.btnModify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(157)))), ((int)(((byte)(111)))));
            this.btnModify.BorderRadius = 15;
            this.btnModify.BorderSize = 0;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(311, 293);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(150, 40);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "確定修改";
            this.btnModify.TextColor = System.Drawing.Color.White;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnClearn
            // 
            this.btnClearn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearn.BackColor = System.Drawing.SystemColors.Control;
            this.btnClearn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnClearn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(158)))), ((int)(((byte)(162)))));
            this.btnClearn.BorderRadius = 15;
            this.btnClearn.BorderSize = 2;
            this.btnClearn.FlatAppearance.BorderSize = 0;
            this.btnClearn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(158)))), ((int)(((byte)(162)))));
            this.btnClearn.Location = new System.Drawing.Point(130, 293);
            this.btnClearn.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearn.Name = "btnClearn";
            this.btnClearn.Size = new System.Drawing.Size(150, 40);
            this.btnClearn.TabIndex = 13;
            this.btnClearn.Text = "清除重填";
            this.btnClearn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(158)))), ((int)(((byte)(162)))));
            this.btnClearn.UseVisualStyleBackColor = false;
            this.btnClearn.Click += new System.EventHandler(this.btnClearn_Click);
            // 
            // UpdatePwdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UpdatePwdControl";
            this.Size = new System.Drawing.Size(670, 500);
            this.Load += new System.EventHandler(this.UpdatePwdControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJButton btnModify;
        private RJButton btnClearn;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentlyPwd;
    }
}
