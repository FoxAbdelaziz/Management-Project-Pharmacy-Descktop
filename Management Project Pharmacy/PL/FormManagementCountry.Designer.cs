namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementCountry
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtserach = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodecountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.ptndelete = new System.Windows.Forms.Button();
            this.ptnadd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ptnclose = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ptndisplay
            // 
            this.ptndisplay.Location = new System.Drawing.Point(15, 229);
            this.ptndisplay.Name = "ptndisplay";
            this.ptndisplay.Size = new System.Drawing.Size(119, 23);
            this.ptndisplay.TabIndex = 1;
            this.ptndisplay.Text = "عرض كل الدول";
            this.ptndisplay.UseVisualStyleBackColor = true;
            this.ptndisplay.Click += new System.EventHandler(this.ptndisplay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "الكلمة المراد البحث عنها ";
            // 
            // txtserach
            // 
            this.txtserach.Location = new System.Drawing.Point(241, 15);
            this.txtserach.Name = "txtserach";
            this.txtserach.Size = new System.Drawing.Size(408, 26);
            this.txtserach.TabIndex = 10;
            this.txtserach.TextChanged += new System.EventHandler(this.txtserach_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtcodecountry);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Location = new System.Drawing.Point(12, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات الدولة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "كود الدولة ";
            // 
            // txtcodecountry
            // 
            this.txtcodecountry.Location = new System.Drawing.Point(6, 96);
            this.txtcodecountry.Name = "txtcodecountry";
            this.txtcodecountry.Size = new System.Drawing.Size(143, 26);
            this.txtcodecountry.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "رقم الدولة ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "اسم الدولة ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(6, 64);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(143, 26);
            this.txt_name.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(6, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(143, 26);
            this.txt_id.TabIndex = 9;
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(93, 200);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(75, 23);
            this.ptnupdate.TabIndex = 2;
            this.ptnupdate.Text = "تعديل ";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(174, 200);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(75, 23);
            this.ptndelete.TabIndex = 3;
            this.ptndelete.Text = "حذف";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // ptnadd
            // 
            this.ptnadd.Location = new System.Drawing.Point(12, 200);
            this.ptnadd.Name = "ptnadd";
            this.ptnadd.Size = new System.Drawing.Size(75, 23);
            this.ptnadd.TabIndex = 4;
            this.ptnadd.Text = "أضافة";
            this.ptnadd.UseVisualStyleBackColor = true;
            this.ptnadd.Click += new System.EventHandler(this.ptnadd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv);
            this.groupBox4.Location = new System.Drawing.Point(255, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 307);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "كل الدول";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 22);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(388, 282);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ptnclose
            // 
            this.ptnclose.Location = new System.Drawing.Point(140, 229);
            this.ptnclose.Name = "ptnclose";
            this.ptnclose.Size = new System.Drawing.Size(109, 23);
            this.ptnclose.TabIndex = 11;
            this.ptnclose.Text = "خروج";
            this.ptnclose.UseVisualStyleBackColor = true;
            this.ptnclose.Click += new System.EventHandler(this.ptnclose_Click);
            // 
            // FormManagementCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 365);
            this.Controls.Add(this.ptnclose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtserach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ptnadd);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnupdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ptndisplay);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementCountry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الدول";
            this.Load += new System.EventHandler(this.FormManagementCountry_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ptndisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtserach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.Button ptnadd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodecountry;
        private System.Windows.Forms.Button ptnclose;
    }
}