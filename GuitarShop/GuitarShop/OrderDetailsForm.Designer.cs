namespace GuitarShop
{
    partial class OrderDetailsForm
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
            this.DGVorderdetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVorderdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVorderdetail
            // 
            this.DGVorderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVorderdetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVorderdetail.Location = new System.Drawing.Point(0, 0);
            this.DGVorderdetail.Name = "DGVorderdetail";
            this.DGVorderdetail.RowTemplate.Height = 24;
            this.DGVorderdetail.Size = new System.Drawing.Size(797, 246);
            this.DGVorderdetail.TabIndex = 0;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 246);
            this.Controls.Add(this.DGVorderdetail);
            this.Name = "OrderDetailsForm";
            this.Text = "OrderDetailsForm";
            this.Activated += new System.EventHandler(this.OrderDetailsForm_Activated);
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVorderdetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVorderdetail;
    }
}