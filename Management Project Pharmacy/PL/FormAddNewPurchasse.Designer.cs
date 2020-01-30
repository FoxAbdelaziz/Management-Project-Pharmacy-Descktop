namespace Management_Project_Pharmacy.PL
{
    partial class FormAddNewPurchasse
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
            this.txtProductExpiredate = new System.Windows.Forms.DateTimePicker();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtproduct_price = new System.Windows.Forms.TextBox();
            this.txtproduct_name = new System.Windows.Forms.TextBox();
            this.txtproduct_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ptnaddproduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtReqTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptndelete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptnaddsupplier = new System.Windows.Forms.Button();
            this.txtsu_phone = new System.Windows.Forms.TextBox();
            this.txtsu_name = new System.Windows.Forms.TextBox();
            this.txtsu_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReqdate = new System.Windows.Forms.DateTimePicker();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.ptnprint = new System.Windows.Forms.Button();
            this.ptnsave = new System.Windows.Forms.Button();
            this.ptnnewpurchasse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductExpiredate);
            this.groupBox1.Controls.Add(this.txtqty);
            this.groupBox1.Controls.Add(this.txtproduct_price);
            this.groupBox1.Controls.Add(this.txtproduct_name);
            this.groupBox1.Controls.Add(this.txtproduct_id);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ptnaddproduct);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtReqTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ptndelete);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتجات";
            // 
            // txtProductExpiredate
            // 
            this.txtProductExpiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtProductExpiredate.Location = new System.Drawing.Point(335, 74);
            this.txtProductExpiredate.Name = "txtProductExpiredate";
            this.txtProductExpiredate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductExpiredate.ShowCheckBox = true;
            this.txtProductExpiredate.Size = new System.Drawing.Size(165, 26);
            this.txtProductExpiredate.TabIndex = 20;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(5, 74);
            this.txtqty.MaxLength = 6;
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(166, 26);
            this.txtqty.TabIndex = 19;
            this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprod_qty_KeyDown);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprod_qty_KeyPress);
            // 
            // txtproduct_price
            // 
            this.txtproduct_price.Location = new System.Drawing.Point(170, 74);
            this.txtproduct_price.Name = "txtproduct_price";
            this.txtproduct_price.ReadOnly = true;
            this.txtproduct_price.Size = new System.Drawing.Size(166, 26);
            this.txtproduct_price.TabIndex = 17;
            this.txtproduct_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproduct_name
            // 
            this.txtproduct_name.Location = new System.Drawing.Point(498, 74);
            this.txtproduct_name.Name = "txtproduct_name";
            this.txtproduct_name.ReadOnly = true;
            this.txtproduct_name.Size = new System.Drawing.Size(166, 26);
            this.txtproduct_name.TabIndex = 16;
            this.txtproduct_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproduct_id
            // 
            this.txtproduct_id.Location = new System.Drawing.Point(664, 74);
            this.txtproduct_id.Name = "txtproduct_id";
            this.txtproduct_id.ReadOnly = true;
            this.txtproduct_id.Size = new System.Drawing.Size(166, 26);
            this.txtproduct_id.TabIndex = 15;
            this.txtproduct_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(4, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 27);
            this.label11.TabIndex = 14;
            this.label11.Text = "الكمية";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(170, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 27);
            this.label10.TabIndex = 13;
            this.label10.Text = "سعر المنتج";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(334, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "تاريخ الصلاحية";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(498, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "اسم المنتج";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptnaddproduct
            // 
            this.ptnaddproduct.Enabled = false;
            this.ptnaddproduct.Location = new System.Drawing.Point(830, 47);
            this.ptnaddproduct.Name = "ptnaddproduct";
            this.ptnaddproduct.Size = new System.Drawing.Size(40, 53);
            this.ptnaddproduct.TabIndex = 10;
            this.ptnaddproduct.Text = "....";
            this.ptnaddproduct.UseVisualStyleBackColor = true;
            this.ptnaddproduct.Click += new System.EventHandler(this.ptnaddproduct_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(664, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "رقم المنتج";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtReqTotal
            // 
            this.TxtReqTotal.Location = new System.Drawing.Point(5, 271);
            this.TxtReqTotal.Name = "TxtReqTotal";
            this.TxtReqTotal.ReadOnly = true;
            this.TxtReqTotal.Size = new System.Drawing.Size(152, 26);
            this.TxtReqTotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "الأجمالى";
            // 
            // ptndelete
            // 
            this.ptndelete.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Delete;
            this.ptndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptndelete.Enabled = false;
            this.ptndelete.Location = new System.Drawing.Point(721, 269);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(143, 23);
            this.ptndelete.TabIndex = 6;
            this.ptndelete.Text = "حذف الصنف المحدد";
            this.ptndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(4, 72);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(866, 196);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptnaddsupplier);
            this.groupBox2.Controls.Add(this.txtsu_phone);
            this.groupBox2.Controls.Add(this.txtsu_name);
            this.groupBox2.Controls.Add(this.txtsu_id);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(545, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المورد";
            // 
            // ptnaddsupplier
            // 
            this.ptnaddsupplier.Enabled = false;
            this.ptnaddsupplier.Location = new System.Drawing.Point(25, 37);
            this.ptnaddsupplier.Name = "ptnaddsupplier";
            this.ptnaddsupplier.Size = new System.Drawing.Size(75, 26);
            this.ptnaddsupplier.TabIndex = 6;
            this.ptnaddsupplier.Text = "....................";
            this.ptnaddsupplier.UseVisualStyleBackColor = true;
            this.ptnaddsupplier.Click += new System.EventHandler(this.ptnaddsupplier_Click);
            // 
            // txtsu_phone
            // 
            this.txtsu_phone.Location = new System.Drawing.Point(25, 99);
            this.txtsu_phone.Name = "txtsu_phone";
            this.txtsu_phone.ReadOnly = true;
            this.txtsu_phone.Size = new System.Drawing.Size(227, 26);
            this.txtsu_phone.TabIndex = 5;
            // 
            // txtsu_name
            // 
            this.txtsu_name.Location = new System.Drawing.Point(25, 68);
            this.txtsu_name.Name = "txtsu_name";
            this.txtsu_name.ReadOnly = true;
            this.txtsu_name.Size = new System.Drawing.Size(227, 26);
            this.txtsu_name.TabIndex = 4;
            // 
            // txtsu_id
            // 
            this.txtsu_id.Location = new System.Drawing.Point(103, 37);
            this.txtsu_id.Name = "txtsu_id";
            this.txtsu_id.ReadOnly = true;
            this.txtsu_id.Size = new System.Drawing.Size(149, 26);
            this.txtsu_id.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "اسم المورد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "رقم الموبايل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "معرف المورد";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtReqdate);
            this.groupBox3.Controls.Add(this.txtBuyerName);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 134);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الفاتورة ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم المشترى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "تاريخ الفاتورة";
            // 
            // txtReqdate
            // 
            this.txtReqdate.Location = new System.Drawing.Point(13, 40);
            this.txtReqdate.Name = "txtReqdate";
            this.txtReqdate.Size = new System.Drawing.Size(284, 26);
            this.txtReqdate.TabIndex = 7;
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(13, 83);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.ReadOnly = true;
            this.txtBuyerName.Size = new System.Drawing.Size(284, 26);
            this.txtBuyerName.TabIndex = 6;
            this.txtBuyerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptnprint
            // 
            this.ptnprint.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Print;
            this.ptnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnprint.Enabled = false;
            this.ptnprint.Location = new System.Drawing.Point(464, 455);
            this.ptnprint.Name = "ptnprint";
            this.ptnprint.Size = new System.Drawing.Size(135, 23);
            this.ptnprint.TabIndex = 2;
            this.ptnprint.Text = "طباعة الفاتورة ";
            this.ptnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnprint.UseVisualStyleBackColor = true;
            this.ptnprint.Click += new System.EventHandler(this.ptnprint_Click);
            // 
            // ptnsave
            // 
            this.ptnsave.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Save;
            this.ptnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnsave.Enabled = false;
            this.ptnsave.Location = new System.Drawing.Point(304, 457);
            this.ptnsave.Name = "ptnsave";
            this.ptnsave.Size = new System.Drawing.Size(154, 23);
            this.ptnsave.TabIndex = 4;
            this.ptnsave.Text = "حفظ بيانات الفاتورة ";
            this.ptnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnsave.UseVisualStyleBackColor = true;
            this.ptnsave.Click += new System.EventHandler(this.ptnsave_Click);
            // 
            // ptnnewpurchasse
            // 
            this.ptnnewpurchasse.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Add;
            this.ptnnewpurchasse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnnewpurchasse.Location = new System.Drawing.Point(157, 455);
            this.ptnnewpurchasse.Name = "ptnnewpurchasse";
            this.ptnnewpurchasse.Size = new System.Drawing.Size(141, 23);
            this.ptnnewpurchasse.TabIndex = 5;
            this.ptnnewpurchasse.Text = "عملية شراء جديدة ";
            this.ptnnewpurchasse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnnewpurchasse.UseVisualStyleBackColor = true;
            this.ptnnewpurchasse.Click += new System.EventHandler(this.ptnnewpurchasse_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(605, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormAddNewPurchasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ptnnewpurchasse);
            this.Controls.Add(this.ptnsave);
            this.Controls.Add(this.ptnprint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddNewPurchasse";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة شراء جديدة ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ptnprint;
        private System.Windows.Forms.Button ptnsave;
        private System.Windows.Forms.Button ptnnewpurchasse;
        private System.Windows.Forms.DateTimePicker txtReqdate;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ptnaddsupplier;
        private System.Windows.Forms.TextBox txtsu_phone;
        private System.Windows.Forms.TextBox txtsu_name;
        private System.Windows.Forms.TextBox txtsu_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtReqTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ptnaddproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtProductExpiredate;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtproduct_price;
        private System.Windows.Forms.TextBox txtproduct_name;
        private System.Windows.Forms.TextBox txtproduct_id;
        private System.Windows.Forms.Button button2;
    }
}