namespace Management_Project_Pharmacy.PL
{
    partial class FormAddNewOrder
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptnaddcoustomer = new System.Windows.Forms.Button();
            this.txtcu_phone = new System.Windows.Forms.TextBox();
            this.txtcu_name = new System.Windows.Forms.TextBox();
            this.txtcu_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReqdate = new System.Windows.Forms.DateTimePicker();
            this.txtsalername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprod_qty = new System.Windows.Forms.TextBox();
            this.txtproduct_price = new System.Windows.Forms.TextBox();
            this.txtproduct_name = new System.Windows.Forms.TextBox();
            this.txtproduct_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ptnaddproduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptndelete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.ptnsave = new System.Windows.Forms.Button();
            this.ptnprint = new System.Windows.Forms.Button();
            this.ptnneworder = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptnaddcoustomer);
            this.groupBox2.Controls.Add(this.txtcu_phone);
            this.groupBox2.Controls.Add(this.txtcu_name);
            this.groupBox2.Controls.Add(this.txtcu_id);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(534, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 134);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // ptnaddcoustomer
            // 
            this.ptnaddcoustomer.Enabled = false;
            this.ptnaddcoustomer.Location = new System.Drawing.Point(25, 37);
            this.ptnaddcoustomer.Name = "ptnaddcoustomer";
            this.ptnaddcoustomer.Size = new System.Drawing.Size(75, 26);
            this.ptnaddcoustomer.TabIndex = 6;
            this.ptnaddcoustomer.Text = "....................";
            this.ptnaddcoustomer.UseVisualStyleBackColor = true;
            this.ptnaddcoustomer.Click += new System.EventHandler(this.ptnaddcoustomer_Click);
            // 
            // txtcu_phone
            // 
            this.txtcu_phone.Location = new System.Drawing.Point(25, 99);
            this.txtcu_phone.Name = "txtcu_phone";
            this.txtcu_phone.ReadOnly = true;
            this.txtcu_phone.Size = new System.Drawing.Size(227, 26);
            this.txtcu_phone.TabIndex = 5;
            // 
            // txtcu_name
            // 
            this.txtcu_name.Location = new System.Drawing.Point(25, 68);
            this.txtcu_name.Name = "txtcu_name";
            this.txtcu_name.ReadOnly = true;
            this.txtcu_name.Size = new System.Drawing.Size(227, 26);
            this.txtcu_name.TabIndex = 4;
            // 
            // txtcu_id
            // 
            this.txtcu_id.Location = new System.Drawing.Point(103, 37);
            this.txtcu_id.Name = "txtcu_id";
            this.txtcu_id.ReadOnly = true;
            this.txtcu_id.Size = new System.Drawing.Size(149, 26);
            this.txtcu_id.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "اسم العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "رقم الموبايل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "كود العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtReqdate);
            this.groupBox3.Controls.Add(this.txtsalername);
            this.groupBox3.Location = new System.Drawing.Point(15, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 134);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الفاتورة ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "اسم البائع";
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
            // txtsalername
            // 
            this.txtsalername.Location = new System.Drawing.Point(13, 83);
            this.txtsalername.Name = "txtsalername";
            this.txtsalername.ReadOnly = true;
            this.txtsalername.Size = new System.Drawing.Size(284, 26);
            this.txtsalername.TabIndex = 6;
            this.txtsalername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprod_qty);
            this.groupBox1.Controls.Add(this.txtproduct_price);
            this.groupBox1.Controls.Add(this.txtproduct_name);
            this.groupBox1.Controls.Add(this.txtproduct_id);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ptnaddproduct);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOrderTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ptndelete);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(15, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتجات";
            // 
            // txtprod_qty
            // 
            this.txtprod_qty.Location = new System.Drawing.Point(1, 50);
            this.txtprod_qty.MaxLength = 4;
            this.txtprod_qty.Name = "txtprod_qty";
            this.txtprod_qty.Size = new System.Drawing.Size(216, 26);
            this.txtprod_qty.TabIndex = 19;
            this.txtprod_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprod_qty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprod_qty_KeyDown);
            this.txtprod_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprod_qty_KeyPress);
            // 
            // txtproduct_price
            // 
            this.txtproduct_price.Location = new System.Drawing.Point(214, 50);
            this.txtproduct_price.Name = "txtproduct_price";
            this.txtproduct_price.ReadOnly = true;
            this.txtproduct_price.Size = new System.Drawing.Size(216, 26);
            this.txtproduct_price.TabIndex = 17;
            this.txtproduct_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproduct_name
            // 
            this.txtproduct_name.Location = new System.Drawing.Point(430, 50);
            this.txtproduct_name.Name = "txtproduct_name";
            this.txtproduct_name.ReadOnly = true;
            this.txtproduct_name.Size = new System.Drawing.Size(207, 26);
            this.txtproduct_name.TabIndex = 16;
            this.txtproduct_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtproduct_id
            // 
            this.txtproduct_id.Location = new System.Drawing.Point(637, 50);
            this.txtproduct_id.Name = "txtproduct_id";
            this.txtproduct_id.ReadOnly = true;
            this.txtproduct_id.Size = new System.Drawing.Size(193, 26);
            this.txtproduct_id.TabIndex = 15;
            this.txtproduct_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(1, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 26);
            this.label11.TabIndex = 14;
            this.label11.Text = "الكمية";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(214, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "سعر المنتج";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(430, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 26);
            this.label8.TabIndex = 11;
            this.label8.Text = "اسم المنتج";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptnaddproduct
            // 
            this.ptnaddproduct.Enabled = false;
            this.ptnaddproduct.Location = new System.Drawing.Point(829, 23);
            this.ptnaddproduct.Name = "ptnaddproduct";
            this.ptnaddproduct.Size = new System.Drawing.Size(41, 53);
            this.ptnaddproduct.TabIndex = 10;
            this.ptnaddproduct.Text = "....";
            this.ptnaddproduct.UseVisualStyleBackColor = true;
            this.ptnaddproduct.Click += new System.EventHandler(this.ptnaddproduct_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(637, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "رقم المنتج";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(5, 271);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(152, 26);
            this.txtOrderTotal.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "الأجمالى:";
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
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(0, 48);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(870, 215);
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
            // button2
            // 
            this.button2.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(633, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "خروج";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ptnsave
            // 
            this.ptnsave.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Save;
            this.ptnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnsave.Enabled = false;
            this.ptnsave.Location = new System.Drawing.Point(352, 453);
            this.ptnsave.Name = "ptnsave";
            this.ptnsave.Size = new System.Drawing.Size(141, 23);
            this.ptnsave.TabIndex = 10;
            this.ptnsave.Text = "حفظ بيانات الفاتورة ";
            this.ptnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnsave.UseVisualStyleBackColor = true;
            this.ptnsave.Click += new System.EventHandler(this.ptnsave_Click);
            // 
            // ptnprint
            // 
            this.ptnprint.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Print;
            this.ptnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnprint.Enabled = false;
            this.ptnprint.Location = new System.Drawing.Point(499, 453);
            this.ptnprint.Name = "ptnprint";
            this.ptnprint.Size = new System.Drawing.Size(128, 23);
            this.ptnprint.TabIndex = 9;
            this.ptnprint.Text = "طباعة الفاتورة ";
            this.ptnprint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnprint.UseVisualStyleBackColor = true;
            // 
            // ptnneworder
            // 
            this.ptnneworder.BackgroundImage = global::Management_Project_Pharmacy.Properties.Resources.Add;
            this.ptnneworder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptnneworder.Location = new System.Drawing.Point(206, 453);
            this.ptnneworder.Name = "ptnneworder";
            this.ptnneworder.Size = new System.Drawing.Size(128, 23);
            this.ptnneworder.TabIndex = 11;
            this.ptnneworder.Text = "عملية بيع جديدة ";
            this.ptnneworder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ptnneworder.UseVisualStyleBackColor = true;
            this.ptnneworder.Click += new System.EventHandler(this.ptnneworder_Click);
            // 
            // FormAddNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ptnsave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ptnprint);
            this.Controls.Add(this.ptnneworder);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormAddNewOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة بيع جديدة";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ptnsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ptnaddcoustomer;
        private System.Windows.Forms.TextBox txtcu_phone;
        private System.Windows.Forms.TextBox txtcu_name;
        private System.Windows.Forms.TextBox txtcu_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtReqdate;
        private System.Windows.Forms.TextBox txtsalername;
        private System.Windows.Forms.Button ptnprint;
        private System.Windows.Forms.Button ptnneworder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprod_qty;
        private System.Windows.Forms.TextBox txtproduct_price;
        private System.Windows.Forms.TextBox txtproduct_name;
        private System.Windows.Forms.TextBox txtproduct_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ptnaddproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
    }
}