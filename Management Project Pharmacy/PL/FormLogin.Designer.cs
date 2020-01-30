namespace Management_Project_Pharmacy
{
    partial class FormLogin
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusernam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ptnloguser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(127, 75);
            this.txtpass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(236, 26);
            this.txtpass.TabIndex = 24;
            this.txtpass.Text = "Admin";
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtusernam
            // 
            this.txtusernam.Location = new System.Drawing.Point(127, 24);
            this.txtusernam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtusernam.Name = "txtusernam";
            this.txtusernam.Size = new System.Drawing.Size(236, 26);
            this.txtusernam.TabIndex = 22;
            this.txtusernam.Text = "Admin";
            this.txtusernam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "كلمة المرور ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "اسم المستخدم ";
            // 
            // ptnloguser
            // 
            this.ptnloguser.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Profile;
            this.ptnloguser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnloguser.Location = new System.Drawing.Point(68, 132);
            this.ptnloguser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ptnloguser.Name = "ptnloguser";
            this.ptnloguser.Size = new System.Drawing.Size(125, 34);
            this.ptnloguser.TabIndex = 28;
            this.ptnloguser.Text = "تسجيل الدخول";
            this.ptnloguser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnloguser.UseVisualStyleBackColor = true;
            this.ptnloguser.Click += new System.EventHandler(this.ptnloguser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Management_Project_Pharmacy.Properties.Resources.login_icon_png_27;
            this.pictureBox2.Location = new System.Drawing.Point(429, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // ptnclose
            // 
            this.ptnclose.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Exit;
            this.ptnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnclose.Location = new System.Drawing.Point(238, 132);
            this.ptnclose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ptnclose.Name = "ptnclose";
            this.ptnclose.Size = new System.Drawing.Size(88, 34);
            this.ptnclose.TabIndex = 26;
            this.ptnclose.Text = "إلغاء";
            this.ptnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnclose.UseVisualStyleBackColor = true;
            this.ptnclose.Click += new System.EventHandler(this.ptnclose_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.ptnloguser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 192);
            this.Controls.Add(this.ptnloguser);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ptnclose);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusernam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ptnloguser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ptnclose;
        public System.Windows.Forms.TextBox txtpass;
        public System.Windows.Forms.TextBox txtusernam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

