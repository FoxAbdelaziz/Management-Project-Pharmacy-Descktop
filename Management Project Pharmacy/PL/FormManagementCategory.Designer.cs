namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementCategory
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ptnselectall = new System.Windows.Forms.Button();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.ptnpirent = new System.Windows.Forms.Button();
            this.ptndelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcatname = new System.Windows.Forms.TextBox();
            this.txtcatid = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptnclose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كل بيانات الاصناف";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(747, 191);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ptnselectall
            // 
            this.ptnselectall.Location = new System.Drawing.Point(64, 391);
            this.ptnselectall.Name = "ptnselectall";
            this.ptnselectall.Size = new System.Drawing.Size(142, 26);
            this.ptnselectall.TabIndex = 1;
            this.ptnselectall.Text = "عرض كل الاصناف ";
            this.ptnselectall.UseVisualStyleBackColor = true;
            this.ptnselectall.Click += new System.EventHandler(this.ptnselectall_Click);
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(212, 391);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(140, 26);
            this.ptnupdate.TabIndex = 2;
            this.ptnupdate.Text = "تعديل بيانات الصنف المحدد";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // ptnpirent
            // 
            this.ptnpirent.Location = new System.Drawing.Point(488, 391);
            this.ptnpirent.Name = "ptnpirent";
            this.ptnpirent.Size = new System.Drawing.Size(108, 26);
            this.ptnpirent.TabIndex = 4;
            this.ptnpirent.Text = "طباعة الاصناف";
            this.ptnpirent.UseVisualStyleBackColor = true;
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(358, 391);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(124, 26);
            this.ptndelete.TabIndex = 3;
            this.ptndelete.Text = "حذف الصنف المحدد";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "معرف الصنف ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "الصنف ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "اسم الصنف المراد البحث عنة ";
            // 
            // txtcatname
            // 
            this.txtcatname.Location = new System.Drawing.Point(6, 86);
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.Size = new System.Drawing.Size(142, 26);
            this.txtcatname.TabIndex = 0;
            // 
            // txtcatid
            // 
            this.txtcatid.Location = new System.Drawing.Point(7, 27);
            this.txtcatid.Name = "txtcatid";
            this.txtcatid.ReadOnly = true;
            this.txtcatid.Size = new System.Drawing.Size(142, 26);
            this.txtcatid.TabIndex = 9;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(454, 85);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(311, 47);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcatid);
            this.groupBox2.Controls.Add(this.txtcatname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الصف المحدد";
            // 
            // ptnclose
            // 
            this.ptnclose.Location = new System.Drawing.Point(602, 391);
            this.ptnclose.Name = "ptnclose";
            this.ptnclose.Size = new System.Drawing.Size(108, 26);
            this.ptnclose.TabIndex = 8;
            this.ptnclose.Text = "خروج";
            this.ptnclose.UseVisualStyleBackColor = true;
            this.ptnclose.Click += new System.EventHandler(this.ptnclose_Click);
            // 
            // FormManagementCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.ptnclose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnpirent);
            this.Controls.Add(this.ptnupdate);
            this.Controls.Add(this.ptnselectall);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementCategory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الخاصة بأدارة الاصناف";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ptnselectall;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.Button ptnpirent;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcatname;
        private System.Windows.Forms.TextBox txtcatid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ptnclose;
    }
}