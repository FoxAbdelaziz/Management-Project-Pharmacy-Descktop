namespace Management_Project_Pharmacy.PL
{
    partial class FormAddNewActiveMateril
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtnameactivematirel = new System.Windows.Forms.TextBox();
            this.ptnadd = new System.Windows.Forms.Button();
            this.ptncancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المادة الفعالة ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف المادة الفعالة";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(130, 72);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdescription.Size = new System.Drawing.Size(248, 67);
            this.txtdescription.TabIndex = 1;
            // 
            // txtnameactivematirel
            // 
            this.txtnameactivematirel.Location = new System.Drawing.Point(130, 21);
            this.txtnameactivematirel.Name = "txtnameactivematirel";
            this.txtnameactivematirel.Size = new System.Drawing.Size(248, 26);
            this.txtnameactivematirel.TabIndex = 0;
            this.txtnameactivematirel.TextChanged += new System.EventHandler(this.txtnameactivematirel_TextChanged);
            // 
            // ptnadd
            // 
            this.ptnadd.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Add;
            this.ptnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnadd.Enabled = false;
            this.ptnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnadd.Location = new System.Drawing.Point(130, 147);
            this.ptnadd.Name = "ptnadd";
            this.ptnadd.Size = new System.Drawing.Size(75, 29);
            this.ptnadd.TabIndex = 2;
            this.ptnadd.Text = "اضافة";
            this.ptnadd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ptnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ptnadd.UseVisualStyleBackColor = true;
            this.ptnadd.Click += new System.EventHandler(this.ptnadd_Click);
            // 
            // ptncancle
            // 
            this.ptncancle.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Exit;
            this.ptncancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptncancle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptncancle.Location = new System.Drawing.Point(272, 150);
            this.ptncancle.Name = "ptncancle";
            this.ptncancle.Size = new System.Drawing.Size(75, 29);
            this.ptncancle.TabIndex = 3;
            this.ptncancle.Text = "إلغاء";
            this.ptncancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptncancle.UseVisualStyleBackColor = true;
            this.ptncancle.Click += new System.EventHandler(this.ptncancle_Click);
            // 
            // FormAddNewActiveMateril
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 185);
            this.Controls.Add(this.ptnadd);
            this.Controls.Add(this.ptncancle);
            this.Controls.Add(this.txtnameactivematirel);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddNewActiveMateril";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مادة فعالة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtnameactivematirel;
        private System.Windows.Forms.Button ptncancle;
        private System.Windows.Forms.Button ptnadd;
    }
}