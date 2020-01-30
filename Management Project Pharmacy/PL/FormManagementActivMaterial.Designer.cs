namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementAcviveMaterial
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAm_Name = new System.Windows.Forms.TextBox();
            this.txtAm_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAm_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ptndelete = new System.Windows.Forms.Button();
            this.ptnpirent = new System.Windows.Forms.Button();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.ptnselectall = new System.Windows.Forms.Button();
            this.lblcount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptnclose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كل بيانات المواد الفعالة";
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
            this.dgv.Size = new System.Drawing.Size(856, 148);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "معرف المادة الفعالة :";
            // 
            // txtAm_Name
            // 
            this.txtAm_Name.Location = new System.Drawing.Point(6, 56);
            this.txtAm_Name.Name = "txtAm_Name";
            this.txtAm_Name.Size = new System.Drawing.Size(221, 26);
            this.txtAm_Name.TabIndex = 0;
            // 
            // txtAm_ID
            // 
            this.txtAm_ID.Location = new System.Drawing.Point(117, 24);
            this.txtAm_ID.Name = "txtAm_ID";
            this.txtAm_ID.ReadOnly = true;
            this.txtAm_ID.Size = new System.Drawing.Size(109, 26);
            this.txtAm_ID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم المادة الفعالة :";
            // 
            // txtAm_Description
            // 
            this.txtAm_Description.Location = new System.Drawing.Point(6, 89);
            this.txtAm_Description.Multiline = true;
            this.txtAm_Description.Name = "txtAm_Description";
            this.txtAm_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAm_Description.Size = new System.Drawing.Size(221, 75);
            this.txtAm_Description.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 8;
            this.label3.Tag = "";
            this.label3.Text = "الوصف :";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(569, 103);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(302, 52);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "اسم المادة الفعالة المراد البحث عنة :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAm_ID);
            this.groupBox2.Controls.Add(this.txtAm_Name);
            this.groupBox2.Controls.Add(this.txtAm_Description);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 171);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات المواد الفعالة";
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(428, 398);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(124, 26);
            this.ptndelete.TabIndex = 3;
            this.ptndelete.Text = "حذف المادة الفعالة ";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // ptnpirent
            // 
            this.ptnpirent.Location = new System.Drawing.Point(558, 398);
            this.ptnpirent.Name = "ptnpirent";
            this.ptnpirent.Size = new System.Drawing.Size(138, 26);
            this.ptnpirent.TabIndex = 4;
            this.ptnpirent.Text = "طباعة المواد الفعالة";
            this.ptnpirent.UseVisualStyleBackColor = true;
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(282, 398);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(140, 26);
            this.ptnupdate.TabIndex = 2;
            this.ptnupdate.Text = "تعديل المادة الفعالة";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // ptnselectall
            // 
            this.ptnselectall.Location = new System.Drawing.Point(110, 398);
            this.ptnselectall.Name = "ptnselectall";
            this.ptnselectall.Size = new System.Drawing.Size(163, 26);
            this.ptnselectall.TabIndex = 1;
            this.ptnselectall.Text = "عرض كل المواد الفعالة";
            this.ptnselectall.UseVisualStyleBackColor = true;
            this.ptnselectall.Click += new System.EventHandler(this.ptnselectall_Click);
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcount.ForeColor = System.Drawing.Color.Red;
            this.lblcount.Location = new System.Drawing.Point(106, 430);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(2, 21);
            this.lblcount.TabIndex = 14;
            this.lblcount.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 15;
            this.label6.Tag = "";
            this.label6.Text = "عدد المواد الفعالة";
            // 
            // ptnclose
            // 
            this.ptnclose.Location = new System.Drawing.Point(702, 398);
            this.ptnclose.Name = "ptnclose";
            this.ptnclose.Size = new System.Drawing.Size(89, 26);
            this.ptnclose.TabIndex = 16;
            this.ptnclose.Text = "خروج";
            this.ptnclose.UseVisualStyleBackColor = true;
            this.ptnclose.Click += new System.EventHandler(this.ptnclose_Click);
            // 
            // FormManagementAcviveMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 460);
            this.Controls.Add(this.ptnclose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnpirent);
            this.Controls.Add(this.ptnupdate);
            this.Controls.Add(this.ptnselectall);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementAcviveMaterial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المواد الفعالة ";
            this.Load += new System.EventHandler(this.FormManagementAcviveMaterial_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAm_Name;
        private System.Windows.Forms.TextBox txtAm_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAm_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.Button ptnpirent;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.Button ptnselectall;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ptnclose;
    }
}