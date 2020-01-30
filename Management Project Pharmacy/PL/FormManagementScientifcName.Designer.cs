namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementScientifcName
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
            this.ptndelete = new System.Windows.Forms.Button();
            this.ptnpirent = new System.Windows.Forms.Button();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.ptnselectall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsnid = new System.Windows.Forms.TextBox();
            this.txtsnname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.ptnclose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(13, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 216);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاسماء العلمية";
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
            this.dgv.Size = new System.Drawing.Size(761, 191);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(373, 358);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(151, 26);
            this.ptndelete.TabIndex = 2;
            this.ptndelete.Text = "حذف الاسم العلمى المحدد";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // ptnpirent
            // 
            this.ptnpirent.Location = new System.Drawing.Point(530, 358);
            this.ptnpirent.Name = "ptnpirent";
            this.ptnpirent.Size = new System.Drawing.Size(158, 26);
            this.ptnpirent.TabIndex = 3;
            this.ptnpirent.Text = "طباعة الاسماء العلمية";
            this.ptnpirent.UseVisualStyleBackColor = true;
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(200, 358);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(167, 26);
            this.ptnupdate.TabIndex = 1;
            this.ptnupdate.Text = "تعديل بيانات الاسم العلمى";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // ptnselectall
            // 
            this.ptnselectall.Location = new System.Drawing.Point(28, 358);
            this.ptnselectall.Name = "ptnselectall";
            this.ptnselectall.Size = new System.Drawing.Size(166, 26);
            this.ptnselectall.TabIndex = 0;
            this.ptnselectall.Text = "عرض كل الاسماء العلمية";
            this.ptnselectall.UseVisualStyleBackColor = true;
            this.ptnselectall.Click += new System.EventHandler(this.ptnselectall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "معرف الاسم العلمى ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "الاسم العلمى ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "الاسم العلمى المراد البحث عنة ";
            // 
            // txtsnid
            // 
            this.txtsnid.Location = new System.Drawing.Point(5, 27);
            this.txtsnid.Name = "txtsnid";
            this.txtsnid.ReadOnly = true;
            this.txtsnid.Size = new System.Drawing.Size(142, 26);
            this.txtsnid.TabIndex = 9;
            // 
            // txtsnname
            // 
            this.txtsnname.Location = new System.Drawing.Point(6, 66);
            this.txtsnname.Name = "txtsnname";
            this.txtsnname.Size = new System.Drawing.Size(181, 26);
            this.txtsnname.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsnid);
            this.groupBox2.Controls.Add(this.txtsnname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 105);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الاسماء العلمية";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(486, 82);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(294, 47);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // ptnclose
            // 
            this.ptnclose.Location = new System.Drawing.Point(694, 358);
            this.ptnclose.Name = "ptnclose";
            this.ptnclose.Size = new System.Drawing.Size(79, 26);
            this.ptnclose.TabIndex = 19;
            this.ptnclose.Text = "خروج";
            this.ptnclose.UseVisualStyleBackColor = true;
            this.ptnclose.Click += new System.EventHandler(this.ptnclose_Click);
            // 
            // FormManagementScientifcName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 388);
            this.Controls.Add(this.ptnclose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnpirent);
            this.Controls.Add(this.ptnupdate);
            this.Controls.Add(this.ptnselectall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtsearch);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementScientifcName";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الاسماء العلمية";
            this.Activated += new System.EventHandler(this.FormManagementScientifcName_Activated);
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
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.Button ptnpirent;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.Button ptnselectall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsnid;
        private System.Windows.Forms.TextBox txtsnname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button ptnclose;
    }
}