namespace GuitarShop
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.btnsignout = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picMain2 = new System.Windows.Forms.PictureBox();
            this.picMain3 = new System.Windows.Forms.PictureBox();
            this.picMain1 = new System.Windows.Forms.PictureBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("辰宇落雁體 Thin", 40F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLogin.Location = new System.Drawing.Point(174, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 77);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("辰宇落雁體 Thin", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCustomer.Location = new System.Drawing.Point(362, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(203, 77);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "會員系統";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Font = new System.Drawing.Font("辰宇落雁體 Thin", 40F);
            this.btnproducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnproducts.Location = new System.Drawing.Point(571, 12);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(203, 77);
            this.btnproducts.TabIndex = 2;
            this.btnproducts.Text = "所有商品";
            this.btnproducts.UseVisualStyleBackColor = true;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // btnsignout
            // 
            this.btnsignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignout.FlatAppearance.BorderSize = 0;
            this.btnsignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignout.Font = new System.Drawing.Font("辰宇落雁體 Thin", 40F);
            this.btnsignout.ForeColor = System.Drawing.Color.Firebrick;
            this.btnsignout.Location = new System.Drawing.Point(989, 12);
            this.btnsignout.Name = "btnsignout";
            this.btnsignout.Size = new System.Drawing.Size(203, 77);
            this.btnsignout.TabIndex = 3;
            this.btnsignout.Text = "登出";
            this.btnsignout.UseVisualStyleBackColor = true;
            this.btnsignout.Click += new System.EventHandler(this.btnsignout_Click);
            // 
            // btnorder
            // 
            this.btnorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnorder.FlatAppearance.BorderSize = 0;
            this.btnorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnorder.Font = new System.Drawing.Font("辰宇落雁體 Thin", 40F);
            this.btnorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnorder.Location = new System.Drawing.Point(780, 12);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(203, 77);
            this.btnorder.TabIndex = 4;
            this.btnorder.Text = "查詢訂單";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 1F);
            this.label1.Location = new System.Drawing.Point(92, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1165, 1);
            this.label1.TabIndex = 5;
            // 
            // picMain2
            // 
            this.picMain2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMain2.Image = global::GuitarShop.Properties.Resources.Main2;
            this.picMain2.Location = new System.Drawing.Point(188, 507);
            this.picMain2.Name = "picMain2";
            this.picMain2.Size = new System.Drawing.Size(120, 120);
            this.picMain2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain2.TabIndex = 9;
            this.picMain2.TabStop = false;
            this.picMain2.Click += new System.EventHandler(this.picMain2_Click);
            // 
            // picMain3
            // 
            this.picMain3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMain3.Image = global::GuitarShop.Properties.Resources.Designer1;
            this.picMain3.Location = new System.Drawing.Point(323, 507);
            this.picMain3.Name = "picMain3";
            this.picMain3.Size = new System.Drawing.Size(120, 120);
            this.picMain3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain3.TabIndex = 8;
            this.picMain3.TabStop = false;
            this.picMain3.Click += new System.EventHandler(this.picMain3_Click);
            // 
            // picMain1
            // 
            this.picMain1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMain1.Image = global::GuitarShop.Properties.Resources.Main1;
            this.picMain1.Location = new System.Drawing.Point(53, 507);
            this.picMain1.Name = "picMain1";
            this.picMain1.Size = new System.Drawing.Size(120, 120);
            this.picMain1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain1.TabIndex = 7;
            this.picMain1.TabStop = false;
            this.picMain1.Click += new System.EventHandler(this.picMain1_Click);
            // 
            // picMain
            // 
            this.picMain.Image = global::GuitarShop.Properties.Resources.Main1;
            this.picMain.Location = new System.Drawing.Point(53, 95);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(390, 390);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 6;
            this.picMain.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans TC", 38F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(668, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(440, 74);
            this.label2.TabIndex = 10;
            this.label2.Text = "吉他後臺管理系統";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(500, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(815, 206);
            this.label3.TabIndex = 11;
            this.label3.Text = "專為愛好者與專業音樂家設計。吉他以高品質的實木製作，展現出自然的溫暖音色與豐富的共鳴。其精細打磨的暗色指板、六根鋼弦以及完美調校的琴頭設計，不僅提供了出色的演奏手" +
    "感，還確保了持久的音準穩定性。";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(500, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(815, 206);
            this.label4.TabIndex = 12;
            this.label4.Text = "吉他採用了人體工學設計，無論站立或坐下彈奏，都能讓演奏者感到舒適自如。其光滑的琴身和亮眼的琴橋設計，不僅提升了視覺美感，還讓音色更具穿透力與平衡感。無論是彈奏流行" +
    "樂、民謠還是經典的吉他曲目，這款吉他都能為您帶來出色的表現。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(1373, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picMain2);
            this.Controls.Add(this.picMain3);
            this.Controls.Add(this.picMain1);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.btnsignout);
            this.Controls.Add(this.btnproducts);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btnsignout;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.PictureBox picMain1;
        private System.Windows.Forms.PictureBox picMain3;
        private System.Windows.Forms.PictureBox picMain2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnCustomer;
    }
}

