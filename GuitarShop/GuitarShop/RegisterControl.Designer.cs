namespace GuitarShop
{
    partial class RegisterControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.txt_Register_birthday = new System.Windows.Forms.DateTimePicker();
            this.txt_Reigister_PwdCheck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReigister_Password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReigister_Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmitReigister = new GuitarShop.RJButton();
            this.txtRegister_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegister_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 500);
            this.panel2.TabIndex = 1;
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.txt_Register_birthday);
            this.panelRegister.Controls.Add(this.txt_Reigister_PwdCheck);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.txtReigister_Password);
            this.panelRegister.Controls.Add(this.label8);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.txtReigister_Phone);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.btnSubmitReigister);
            this.panelRegister.Controls.Add(this.txtRegister_Email);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.txtRegister_Name);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Location = new System.Drawing.Point(200, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(500, 500);
            this.panelRegister.TabIndex = 2;
            // 
            // txt_Register_birthday
            // 
            this.txt_Register_birthday.CalendarFont = new System.Drawing.Font("新細明體", 16F);
            this.txt_Register_birthday.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.txt_Register_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_Register_birthday.Location = new System.Drawing.Point(227, 262);
            this.txt_Register_birthday.MaxDate = new System.DateTime(2500, 12, 12, 0, 0, 0, 0);
            this.txt_Register_birthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txt_Register_birthday.Name = "txt_Register_birthday";
            this.txt_Register_birthday.Size = new System.Drawing.Size(157, 27);
            this.txt_Register_birthday.TabIndex = 24;
            this.txt_Register_birthday.Value = new System.DateTime(2024, 11, 4, 0, 0, 0, 0);
            this.txt_Register_birthday.ValueChanged += new System.EventHandler(this.txt_Register_birthday_ValueChanged);
            // 
            // txt_Reigister_PwdCheck
            // 
            this.txt_Reigister_PwdCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Reigister_PwdCheck.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Reigister_PwdCheck.Location = new System.Drawing.Point(227, 349);
            this.txt_Reigister_PwdCheck.MaxLength = 25;
            this.txt_Reigister_PwdCheck.Name = "txt_Reigister_PwdCheck";
            this.txt_Reigister_PwdCheck.PasswordChar = '*';
            this.txt_Reigister_PwdCheck.Size = new System.Drawing.Size(157, 29);
            this.txt_Reigister_PwdCheck.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(111, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "密碼確認";
            // 
            // txtReigister_Password
            // 
            this.txtReigister_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReigister_Password.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReigister_Password.Location = new System.Drawing.Point(227, 303);
            this.txtReigister_Password.MaxLength = 25;
            this.txtReigister_Password.Name = "txtReigister_Password";
            this.txtReigister_Password.PasswordChar = '*';
            this.txtReigister_Password.Size = new System.Drawing.Size(157, 29);
            this.txtReigister_Password.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(111, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 26);
            this.label8.TabIndex = 20;
            this.label8.Text = "密碼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(111, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "生日";
            // 
            // txtReigister_Phone
            // 
            this.txtReigister_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReigister_Phone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReigister_Phone.Location = new System.Drawing.Point(227, 210);
            this.txtReigister_Phone.MaxLength = 25;
            this.txtReigister_Phone.Name = "txtReigister_Phone";
            this.txtReigister_Phone.Size = new System.Drawing.Size(157, 29);
            this.txtReigister_Phone.TabIndex = 17;
            this.txtReigister_Phone.Leave += new System.EventHandler(this.txtReigister_Phone_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(111, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "手機";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(104, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 1);
            this.label4.TabIndex = 15;
            // 
            // btnSubmitReigister
            // 
            this.btnSubmitReigister.BackColor = System.Drawing.Color.Plum;
            this.btnSubmitReigister.BackgroundColor = System.Drawing.Color.Plum;
            this.btnSubmitReigister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSubmitReigister.BorderRadius = 40;
            this.btnSubmitReigister.BorderSize = 0;
            this.btnSubmitReigister.FlatAppearance.BorderSize = 0;
            this.btnSubmitReigister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitReigister.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSubmitReigister.ForeColor = System.Drawing.Color.Transparent;
            this.btnSubmitReigister.Location = new System.Drawing.Point(189, 430);
            this.btnSubmitReigister.Name = "btnSubmitReigister";
            this.btnSubmitReigister.Size = new System.Drawing.Size(150, 40);
            this.btnSubmitReigister.TabIndex = 14;
            this.btnSubmitReigister.Text = "會員註冊";
            this.btnSubmitReigister.TextColor = System.Drawing.Color.Transparent;
            this.btnSubmitReigister.UseVisualStyleBackColor = false;
            this.btnSubmitReigister.Click += new System.EventHandler(this.btnSubmitReigister_Click);
            // 
            // txtRegister_Email
            // 
            this.txtRegister_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegister_Email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRegister_Email.Location = new System.Drawing.Point(227, 160);
            this.txtRegister_Email.MaxLength = 25;
            this.txtRegister_Email.Name = "txtRegister_Email";
            this.txtRegister_Email.Size = new System.Drawing.Size(157, 29);
            this.txtRegister_Email.TabIndex = 12;
            this.txtRegister_Email.Leave += new System.EventHandler(this.txtRegister_Email_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(111, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // txtRegister_Name
            // 
            this.txtRegister_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegister_Name.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRegister_Name.Location = new System.Drawing.Point(227, 113);
            this.txtRegister_Name.MaxLength = 25;
            this.txtRegister_Name.Name = "txtRegister_Name";
            this.txtRegister_Name.Size = new System.Drawing.Size(157, 29);
            this.txtRegister_Name.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(111, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Sans TC Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(154, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = " 會員註冊";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.RegisterControl_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panelRegister;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtRegister_Email;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtRegister_Name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Reigister_PwdCheck;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtReigister_Password;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtReigister_Phone;
        public System.Windows.Forms.Label label6;
        private RJButton btnSubmitReigister;
        private System.Windows.Forms.DateTimePicker txt_Register_birthday;
    }
}
