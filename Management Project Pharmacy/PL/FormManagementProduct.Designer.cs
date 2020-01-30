namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementProduct
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptndelete = new System.Windows.Forms.Button();
            this.ptnpirent = new System.Windows.Forms.Button();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.ptnselectall = new System.Windows.Forms.Button();
            this.ptnaddnew = new System.Windows.Forms.Button();
            this.ptnshowpic = new System.Windows.Forms.Button();
            this.ptnprintone = new System.Windows.Forms.Button();
            this.ptnsave = new System.Windows.Forms.Button();
            this.ptnExpireDate = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptnclose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(3, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1166, 310);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المنتجات";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1160, 285);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.MinimumWidth = 4;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 50F;
            this.Column10.HeaderText = "الصنف";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 55F;
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.MinimumWidth = 4;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 70F;
            this.Column3.HeaderText = "المادة الفعالة";
            this.Column3.MinimumWidth = 4;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "الاسم العلمى";
            this.Column4.MinimumWidth = 4;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 70F;
            this.Column5.HeaderText = "سعر الشراء";
            this.Column5.MinimumWidth = 4;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 75F;
            this.Column6.HeaderText = "السعر للجمهور";
            this.Column6.MinimumWidth = 4;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 80F;
            this.Column7.HeaderText = "الكمية فى المخزن";
            this.Column7.MinimumWidth = 4;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 45F;
            this.Column8.HeaderText = "الباركود";
            this.Column8.MinimumWidth = 4;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 45F;
            this.Column9.HeaderText = "الوصف";
            this.Column9.MinimumWidth = 4;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(466, 375);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(124, 26);
            this.ptndelete.TabIndex = 2;
            this.ptndelete.Text = "حذف المنتج";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // ptnpirent
            // 
            this.ptnpirent.Location = new System.Drawing.Point(596, 375);
            this.ptnpirent.Name = "ptnpirent";
            this.ptnpirent.Size = new System.Drawing.Size(203, 26);
            this.ptnpirent.TabIndex = 3;
            this.ptnpirent.Text = "طباعة كل المنتجات";
            this.ptnpirent.UseVisualStyleBackColor = true;
            this.ptnpirent.Click += new System.EventHandler(this.ptnpirent_Click);
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(320, 375);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(140, 26);
            this.ptnupdate.TabIndex = 1;
            this.ptnupdate.Text = "تعديل المنتج";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // ptnselectall
            // 
            this.ptnselectall.Location = new System.Drawing.Point(152, 404);
            this.ptnselectall.Name = "ptnselectall";
            this.ptnselectall.Size = new System.Drawing.Size(163, 26);
            this.ptnselectall.TabIndex = 4;
            this.ptnselectall.Text = "عرض كل المنتجات";
            this.ptnselectall.UseVisualStyleBackColor = true;
            this.ptnselectall.Click += new System.EventHandler(this.ptnselectall_Click);
            // 
            // ptnaddnew
            // 
            this.ptnaddnew.Location = new System.Drawing.Point(152, 375);
            this.ptnaddnew.Name = "ptnaddnew";
            this.ptnaddnew.Size = new System.Drawing.Size(162, 26);
            this.ptnaddnew.TabIndex = 0;
            this.ptnaddnew.Text = "اضافة منتج جديد";
            this.ptnaddnew.UseVisualStyleBackColor = true;
            this.ptnaddnew.Click += new System.EventHandler(this.ptnaddnew_Click);
            // 
            // ptnshowpic
            // 
            this.ptnshowpic.Location = new System.Drawing.Point(320, 407);
            this.ptnshowpic.Name = "ptnshowpic";
            this.ptnshowpic.Size = new System.Drawing.Size(140, 23);
            this.ptnshowpic.TabIndex = 5;
            this.ptnshowpic.Text = "عرض صورة المنتج";
            this.ptnshowpic.UseVisualStyleBackColor = true;
            this.ptnshowpic.Click += new System.EventHandler(this.ptnshowpic_Click);
            // 
            // ptnprintone
            // 
            this.ptnprintone.Location = new System.Drawing.Point(466, 407);
            this.ptnprintone.Name = "ptnprintone";
            this.ptnprintone.Size = new System.Drawing.Size(124, 23);
            this.ptnprintone.TabIndex = 6;
            this.ptnprintone.Text = "طباعة المنتج المحدد";
            this.ptnprintone.UseVisualStyleBackColor = true;
            this.ptnprintone.Click += new System.EventHandler(this.ptnprintone_Click);
            // 
            // ptnsave
            // 
            this.ptnsave.Location = new System.Drawing.Point(596, 407);
            this.ptnsave.Name = "ptnsave";
            this.ptnsave.Size = new System.Drawing.Size(203, 23);
            this.ptnsave.TabIndex = 7;
            this.ptnsave.Text = "حفظ كل المنتجات فى ملف Excel";
            this.ptnsave.UseVisualStyleBackColor = true;
            this.ptnsave.Click += new System.EventHandler(this.ptnsave_Click);
            // 
            // ptnExpireDate
            // 
            this.ptnExpireDate.Location = new System.Drawing.Point(805, 375);
            this.ptnExpireDate.Name = "ptnExpireDate";
            this.ptnExpireDate.Size = new System.Drawing.Size(160, 55);
            this.ptnExpireDate.TabIndex = 8;
            this.ptnExpireDate.Text = "عرض صلاحيات المنتج";
            this.ptnExpireDate.UseVisualStyleBackColor = true;
            this.ptnExpireDate.Click += new System.EventHandler(this.ptnExpireDate_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(406, 13);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(470, 36);
            this.txtsearch.TabIndex = 15;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "الكلمة المراد البحث عنها ";
            // 
            // ptnclose
            // 
            this.ptnclose.Location = new System.Drawing.Point(971, 375);
            this.ptnclose.Name = "ptnclose";
            this.ptnclose.Size = new System.Drawing.Size(97, 55);
            this.ptnclose.TabIndex = 17;
            this.ptnclose.Text = "خروج";
            this.ptnclose.UseVisualStyleBackColor = true;
            this.ptnclose.Click += new System.EventHandler(this.ptnclose_Click);
            // 
            // FormManagementProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 439);
            this.Controls.Add(this.ptnclose);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptnExpireDate);
            this.Controls.Add(this.ptnsave);
            this.Controls.Add(this.ptnprintone);
            this.Controls.Add(this.ptnshowpic);
            this.Controls.Add(this.ptnaddnew);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnpirent);
            this.Controls.Add(this.ptnupdate);
            this.Controls.Add(this.ptnselectall);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المنتجات";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.Button ptnpirent;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.Button ptnselectall;
        private System.Windows.Forms.Button ptnaddnew;
        private System.Windows.Forms.Button ptnshowpic;
        private System.Windows.Forms.Button ptnprintone;
        private System.Windows.Forms.Button ptnsave;
        private System.Windows.Forms.Button ptnExpireDate;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button ptnclose;
    }
}