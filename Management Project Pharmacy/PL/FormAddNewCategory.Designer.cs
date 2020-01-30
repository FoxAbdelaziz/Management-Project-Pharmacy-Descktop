namespace Management_Project_Pharmacy.PL
{
    partial class FormAddNewCategory
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
            this.txtcatogry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptnadd = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcatogry
            // 
            this.txtcatogry.Location = new System.Drawing.Point(111, 33);
            this.txtcatogry.Name = "txtcatogry";
            this.txtcatogry.Size = new System.Drawing.Size(212, 26);
            this.txtcatogry.TabIndex = 0;
            this.txtcatogry.TextChanged += new System.EventHandler(this.txtcatogry_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "أسم الصنف";
            // 
            // ptnadd
            // 
            this.ptnadd.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Add;
            this.ptnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnadd.Enabled = false;
            this.ptnadd.Location = new System.Drawing.Point(113, 70);
            this.ptnadd.Name = "ptnadd";
            this.ptnadd.Size = new System.Drawing.Size(75, 34);
            this.ptnadd.TabIndex = 1;
            this.ptnadd.Text = "اضافة";
            this.ptnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnadd.UseVisualStyleBackColor = true;
            this.ptnadd.Click += new System.EventHandler(this.ptnadd_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Location = new System.Drawing.Point(296, 70);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(0, 19);
            this.lblcount.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(215, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAddNewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 113);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.ptnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcatogry);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddNewCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صنف جديد ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcatogry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ptnadd;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Button button2;
    }
}