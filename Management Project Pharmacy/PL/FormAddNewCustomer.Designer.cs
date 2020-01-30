namespace Management_Project_Pharmacy.PL
{
    partial class FormAddNewCustomer
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
            this.PTN = new System.Windows.Forms.Button();
            this.txt_cus_name = new System.Windows.Forms.TextBox();
            this.txt_cus_address = new System.Windows.Forms.TextBox();
            this.com_cus_contry = new System.Windows.Forms.ComboBox();
            this.com_cus_city = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cus_mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_cus = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cus)).BeginInit();
            this.SuspendLayout();
            // 
            // PTN
            // 
            this.PTN.Location = new System.Drawing.Point(23, 333);
            this.PTN.Name = "PTN";
            this.PTN.Size = new System.Drawing.Size(115, 35);
            this.PTN.TabIndex = 0;
            this.PTN.UseVisualStyleBackColor = true;
            this.PTN.Click += new System.EventHandler(this.PTN_Click);
            // 
            // txt_cus_name
            // 
            this.txt_cus_name.Location = new System.Drawing.Point(86, 15);
            this.txt_cus_name.Name = "txt_cus_name";
            this.txt_cus_name.Size = new System.Drawing.Size(177, 26);
            this.txt_cus_name.TabIndex = 3;
            // 
            // txt_cus_address
            // 
            this.txt_cus_address.Location = new System.Drawing.Point(86, 49);
            this.txt_cus_address.Name = "txt_cus_address";
            this.txt_cus_address.Size = new System.Drawing.Size(177, 26);
            this.txt_cus_address.TabIndex = 5;
            // 
            // com_cus_contry
            // 
            this.com_cus_contry.BackColor = System.Drawing.Color.White;
            this.com_cus_contry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_cus_contry.FormattingEnabled = true;
            this.com_cus_contry.Location = new System.Drawing.Point(86, 267);
            this.com_cus_contry.Name = "com_cus_contry";
            this.com_cus_contry.Size = new System.Drawing.Size(177, 27);
            this.com_cus_contry.TabIndex = 6;
            this.com_cus_contry.SelectionChangeCommitted += new System.EventHandler(this.com_cus_contry_SelectionChangeCommitted);
            // 
            // com_cus_city
            // 
            this.com_cus_city.BackColor = System.Drawing.Color.White;
            this.com_cus_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_cus_city.FormattingEnabled = true;
            this.com_cus_city.Location = new System.Drawing.Point(86, 299);
            this.com_cus_city.Name = "com_cus_city";
            this.com_cus_city.Size = new System.Drawing.Size(177, 27);
            this.com_cus_city.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم العميل ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "العنوان ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "اسم الدولة ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "صورة العميل ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "اسم المدينة ";
            // 
            // txt_cus_mobile
            // 
            this.txt_cus_mobile.Location = new System.Drawing.Point(86, 82);
            this.txt_cus_mobile.Name = "txt_cus_mobile";
            this.txt_cus_mobile.Size = new System.Drawing.Size(177, 26);
            this.txt_cus_mobile.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "رقم التليفون";
            // 
            // pic_cus
            // 
            this.pic_cus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_cus.Image = global::Management_Project_Pharmacy.Properties.Resources.unknown_avatar;
            this.pic_cus.Location = new System.Drawing.Point(86, 114);
            this.pic_cus.Name = "pic_cus";
            this.pic_cus.Size = new System.Drawing.Size(177, 141);
            this.pic_cus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cus.TabIndex = 2;
            this.pic_cus.TabStop = false;
            this.pic_cus.Click += new System.EventHandler(this.pic_cus_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(156, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cus_mobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_cus_city);
            this.Controls.Add(this.com_cus_contry);
            this.Controls.Add(this.txt_cus_address);
            this.Controls.Add(this.txt_cus_name);
            this.Controls.Add(this.pic_cus);
            this.Controls.Add(this.PTN);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddNewCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_cus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PTN;
        private System.Windows.Forms.PictureBox pic_cus;
        private System.Windows.Forms.TextBox txt_cus_name;
        private System.Windows.Forms.TextBox txt_cus_address;
        private System.Windows.Forms.ComboBox com_cus_contry;
        private System.Windows.Forms.ComboBox com_cus_city;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cus_mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}