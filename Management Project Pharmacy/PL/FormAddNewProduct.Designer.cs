namespace Management_Project_Pharmacy.PL
{
    partial class FormAddNewProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PtnChoose = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.CmbCat = new System.Windows.Forms.ComboBox();
            this.CmbAm = new System.Windows.Forms.ComboBox();
            this.CmbSn = new System.Windows.Forms.ComboBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.txtbuyprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ptnadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PtnChoose);
            this.groupBox1.Controls.Add(this.Pic);
            this.groupBox1.Controls.Add(this.CmbCat);
            this.groupBox1.Controls.Add(this.CmbAm);
            this.groupBox1.Controls.Add(this.CmbSn);
            this.groupBox1.Controls.Add(this.txtbarcode);
            this.groupBox1.Controls.Add(this.txtsellprice);
            this.groupBox1.Controls.Add(this.txtproductname);
            this.groupBox1.Controls.Add(this.txtProductDesc);
            this.groupBox1.Controls.Add(this.txtbuyprice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Ptnadd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "السعر للجمهور";
            // 
            // PtnChoose
            // 
            this.PtnChoose.Location = new System.Drawing.Point(12, 156);
            this.PtnChoose.Name = "PtnChoose";
            this.PtnChoose.Size = new System.Drawing.Size(133, 24);
            this.PtnChoose.TabIndex = 8;
            this.PtnChoose.Text = "اضافة صورة للمنتج ";
            this.PtnChoose.UseVisualStyleBackColor = true;
            this.PtnChoose.Click += new System.EventHandler(this.PtnChoose_Click);
            // 
            // Pic
            // 
            this.Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic.Image = global::Management_Project_Pharmacy.Properties.Resources.Logo;
            this.Pic.Location = new System.Drawing.Point(15, 38);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(122, 114);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 22;
            this.Pic.TabStop = false;
            // 
            // CmbCat
            // 
            this.CmbCat.BackColor = System.Drawing.Color.White;
            this.CmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbCat.FormattingEnabled = true;
            this.CmbCat.Location = new System.Drawing.Point(209, 42);
            this.CmbCat.Name = "CmbCat";
            this.CmbCat.Size = new System.Drawing.Size(267, 27);
            this.CmbCat.TabIndex = 0;
            // 
            // CmbAm
            // 
            this.CmbAm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbAm.FormattingEnabled = true;
            this.CmbAm.Location = new System.Drawing.Point(299, 232);
            this.CmbAm.Name = "CmbAm";
            this.CmbAm.Size = new System.Drawing.Size(176, 27);
            this.CmbAm.TabIndex = 5;
            // 
            // CmbSn
            // 
            this.CmbSn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbSn.FormattingEnabled = true;
            this.CmbSn.Location = new System.Drawing.Point(20, 232);
            this.CmbSn.Name = "CmbSn";
            this.CmbSn.Size = new System.Drawing.Size(177, 27);
            this.CmbSn.TabIndex = 6;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(20, 275);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(456, 26);
            this.txtbarcode.TabIndex = 7;
            // 
            // txtsellprice
            // 
            this.txtsellprice.Location = new System.Drawing.Point(20, 197);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(177, 26);
            this.txtsellprice.TabIndex = 4;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(209, 81);
            this.txtproductname.Multiline = true;
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(267, 26);
            this.txtproductname.TabIndex = 1;
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(156, 120);
            this.txtProductDesc.Multiline = true;
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(320, 64);
            this.txtProductDesc.TabIndex = 2;
            // 
            // txtbuyprice
            // 
            this.txtbuyprice.Location = new System.Drawing.Point(299, 197);
            this.txtbuyprice.Name = "txtbuyprice";
            this.txtbuyprice.Size = new System.Drawing.Size(177, 26);
            this.txtbuyprice.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "الاسم العلمى ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "الباركود ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "صورة المنتج ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "المادة الفعالة ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "سعر الشراء ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "وصف المنتج ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المنتج ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "اسم الصنف ";
            // 
            // Ptnadd
            // 
            this.Ptnadd.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Add;
            this.Ptnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ptnadd.Location = new System.Drawing.Point(297, 307);
            this.Ptnadd.Name = "Ptnadd";
            this.Ptnadd.Size = new System.Drawing.Size(131, 28);
            this.Ptnadd.TabIndex = 9;
            this.Ptnadd.Text = "اضافة منتج جديد";
            this.Ptnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ptnadd.UseVisualStyleBackColor = true;
            this.Ptnadd.Click += new System.EventHandler(this.PTNADD_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(156, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormAddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 345);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddNewProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PtnChoose;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.ComboBox CmbCat;
        private System.Windows.Forms.ComboBox CmbAm;
        private System.Windows.Forms.ComboBox CmbSn;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.TextBox txtbuyprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ptnadd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}