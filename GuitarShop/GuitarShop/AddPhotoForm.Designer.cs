namespace GuitarShop
{
    partial class AddPhotoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGVPhoto = new System.Windows.Forms.DataGridView();
            this.lbphotoID = new System.Windows.Forms.Label();
            this.lbproductID = new System.Windows.Forms.Label();
            this.lbproductname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumSort = new System.Windows.Forms.NumericUpDown();
            this.btnupload = new GuitarShop.RJButton();
            this.btnSetSort = new GuitarShop.RJButton();
            this.btnSelect = new GuitarShop.RJButton();
            this.btndelete = new GuitarShop.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSort)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DGVPhoto
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(198)))), ((int)(((byte)(157)))));
            this.DGVPhoto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVPhoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPhoto.Location = new System.Drawing.Point(12, 360);
            this.DGVPhoto.Name = "DGVPhoto";
            this.DGVPhoto.RowTemplate.Height = 24;
            this.DGVPhoto.Size = new System.Drawing.Size(308, 148);
            this.DGVPhoto.TabIndex = 5;
            this.DGVPhoto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPhoto_CellClick);
            // 
            // lbphotoID
            // 
            this.lbphotoID.AutoSize = true;
            this.lbphotoID.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbphotoID.ForeColor = System.Drawing.Color.Firebrick;
            this.lbphotoID.Location = new System.Drawing.Point(295, 88);
            this.lbphotoID.Name = "lbphotoID";
            this.lbphotoID.Size = new System.Drawing.Size(98, 39);
            this.lbphotoID.TabIndex = 6;
            this.lbphotoID.Text = "圖片ID";
            // 
            // lbproductID
            // 
            this.lbproductID.AutoSize = true;
            this.lbproductID.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbproductID.ForeColor = System.Drawing.Color.Blue;
            this.lbproductID.Location = new System.Drawing.Point(12, 13);
            this.lbproductID.Name = "lbproductID";
            this.lbproductID.Size = new System.Drawing.Size(98, 39);
            this.lbproductID.TabIndex = 7;
            this.lbproductID.Text = "商品ID";
            // 
            // lbproductname
            // 
            this.lbproductname.AutoSize = true;
            this.lbproductname.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbproductname.ForeColor = System.Drawing.Color.Blue;
            this.lbproductname.Location = new System.Drawing.Point(176, 13);
            this.lbproductname.Name = "lbproductname";
            this.lbproductname.Size = new System.Drawing.Size(125, 39);
            this.lbproductname.TabIndex = 12;
            this.lbproductname.Text = "目前名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(295, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "圖片排序";
            // 
            // NumSort
            // 
            this.NumSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumSort.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NumSort.Location = new System.Drawing.Point(423, 166);
            this.NumSort.Name = "NumSort";
            this.NumSort.Size = new System.Drawing.Size(65, 29);
            this.NumSort.TabIndex = 14;
            this.NumSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.btnupload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.btnupload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnupload.BorderRadius = 10;
            this.btnupload.BorderSize = 0;
            this.btnupload.FlatAppearance.BorderSize = 0;
            this.btnupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupload.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnupload.ForeColor = System.Drawing.Color.White;
            this.btnupload.Location = new System.Drawing.Point(338, 299);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(130, 47);
            this.btnupload.TabIndex = 11;
            this.btnupload.Text = "上傳圖片";
            this.btnupload.TextColor = System.Drawing.Color.White;
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btnSetSort
            // 
            this.btnSetSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnSetSort.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(245)))));
            this.btnSetSort.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetSort.BorderRadius = 10;
            this.btnSetSort.BorderSize = 0;
            this.btnSetSort.FlatAppearance.BorderSize = 0;
            this.btnSetSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSort.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetSort.ForeColor = System.Drawing.Color.White;
            this.btnSetSort.Location = new System.Drawing.Point(338, 371);
            this.btnSetSort.Name = "btnSetSort";
            this.btnSetSort.Size = new System.Drawing.Size(130, 44);
            this.btnSetSort.TabIndex = 10;
            this.btnSetSort.Text = "設定排序";
            this.btnSetSort.TextColor = System.Drawing.Color.White;
            this.btnSetSort.UseVisualStyleBackColor = false;
            this.btnSetSort.Click += new System.EventHandler(this.btnSetSort_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(132)))), ((int)(((byte)(94)))));
            this.btnSelect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(132)))), ((int)(((byte)(94)))));
            this.btnSelect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSelect.BorderRadius = 10;
            this.btnSelect.BorderSize = 0;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(338, 224);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(130, 47);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "選取圖片";
            this.btnSelect.TextColor = System.Drawing.Color.White;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.btndelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.btndelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btndelete.BorderRadius = 10;
            this.btndelete.BorderSize = 0;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Noto Sans TC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(338, 451);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(130, 44);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "刪除圖片";
            this.btndelete.TextColor = System.Drawing.Color.White;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // AddPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(495, 517);
            this.Controls.Add(this.NumSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbproductname);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btnSetSort);
            this.Controls.Add(this.lbproductID);
            this.Controls.Add(this.lbphotoID);
            this.Controls.Add(this.DGVPhoto);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddPhotoForm";
            this.Text = "AddPhotoForm";
            this.Load += new System.EventHandler(this.AddPhotoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RJButton btndelete;
        private RJButton btnSelect;
        private System.Windows.Forms.DataGridView DGVPhoto;
        private System.Windows.Forms.Label lbphotoID;
        private System.Windows.Forms.Label lbproductID;
        private RJButton btnSetSort;
        private RJButton btnupload;
        private System.Windows.Forms.Label lbproductname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumSort;
    }
}