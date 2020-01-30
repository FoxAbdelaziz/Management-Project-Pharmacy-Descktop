namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementSupplire
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
            this.ptndisplay = new System.Windows.Forms.Button();
            this.ptnadd = new System.Windows.Forms.Button();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.ptndelete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptndisplay
            // 
            this.ptndisplay.Location = new System.Drawing.Point(114, 272);
            this.ptndisplay.Name = "ptndisplay";
            this.ptndisplay.Size = new System.Drawing.Size(141, 23);
            this.ptndisplay.TabIndex = 0;
            this.ptndisplay.Text = "عرض كل الموردين ";
            this.ptndisplay.UseVisualStyleBackColor = true;
            this.ptndisplay.Click += new System.EventHandler(this.ptndisplay_Click);
            // 
            // ptnadd
            // 
            this.ptnadd.Location = new System.Drawing.Point(261, 272);
            this.ptnadd.Name = "ptnadd";
            this.ptnadd.Size = new System.Drawing.Size(122, 23);
            this.ptnadd.TabIndex = 1;
            this.ptnadd.Text = "اضافة مورد جديد ";
            this.ptnadd.UseVisualStyleBackColor = true;
            this.ptnadd.Click += new System.EventHandler(this.ptnadd_Click);
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(389, 272);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(162, 23);
            this.ptnupdate.TabIndex = 2;
            this.ptnupdate.Text = "تعديل بيانات المورد المحدد ";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(557, 272);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(124, 23);
            this.ptndelete.TabIndex = 3;
            this.ptndelete.Text = "حذف المورد المحدد";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(862, 204);
            this.dgv.TabIndex = 4;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "الكلمة المراد البحث عنها : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(189, 10);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(395, 26);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 229);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموردين ";
            // 
            // ptnClose
            // 
            this.ptnClose.Location = new System.Drawing.Point(687, 271);
            this.ptnClose.Name = "ptnClose";
            this.ptnClose.Size = new System.Drawing.Size(124, 23);
            this.ptnClose.TabIndex = 8;
            this.ptnClose.Text = "خروج";
            this.ptnClose.UseVisualStyleBackColor = true;
            this.ptnClose.Click += new System.EventHandler(this.ptnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "عدد الموردين";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcount.ForeColor = System.Drawing.Color.Red;
            this.lblcount.Location = new System.Drawing.Point(88, 302);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(2, 21);
            this.lblcount.TabIndex = 10;
            // 
            // FormManagementSupplire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 325);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnupdate);
            this.Controls.Add(this.ptnadd);
            this.Controls.Add(this.ptndisplay);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementSupplire";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الموردين ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ptndisplay;
        private System.Windows.Forms.Button ptnadd;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ptnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcount;
    }
}