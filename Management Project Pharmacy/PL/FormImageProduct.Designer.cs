namespace Management_Project_Pharmacy.PL
{
    partial class FormImageProduct
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
            this.PicProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // PicProduct
            // 
            this.PicProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicProduct.Location = new System.Drawing.Point(0, 0);
            this.PicProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PicProduct.Name = "PicProduct";
            this.PicProduct.Size = new System.Drawing.Size(278, 216);
            this.PicProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicProduct.TabIndex = 0;
            this.PicProduct.TabStop = false;
            // 
            // FormImageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 216);
            this.Controls.Add(this.PicProduct);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormImageProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض صورة المنتج";
            ((System.ComponentModel.ISupportInitialize)(this.PicProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PicProduct;
    }
}