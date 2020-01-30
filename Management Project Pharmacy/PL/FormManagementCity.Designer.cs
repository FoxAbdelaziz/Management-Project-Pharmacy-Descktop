namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementCity
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
            this.txtserach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comContryname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_city_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.ptndisplay = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ptnadd = new System.Windows.Forms.Button();
            this.ptndelete = new System.Windows.Forms.Button();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtserach
            // 
            this.txtserach.Location = new System.Drawing.Point(256, 18);
            this.txtserach.Name = "txtserach";
            this.txtserach.Size = new System.Drawing.Size(485, 26);
            this.txtserach.TabIndex = 19;
            this.txtserach.TextChanged += new System.EventHandler(this.txtserach_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "الكلمة المراد البحث عنها :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comContryname);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_city_name);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Location = new System.Drawing.Point(4, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 133);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات المدينه";
            // 
            // comContryname
            // 
            this.comContryname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comContryname.FormattingEnabled = true;
            this.comContryname.Location = new System.Drawing.Point(4, 92);
            this.comContryname.Name = "comContryname";
            this.comContryname.Size = new System.Drawing.Size(161, 27);
            this.comContryname.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "اسم الدولة ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "معرفر المدينة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "اسم المدينة ";
            // 
            // txt_city_name
            // 
            this.txt_city_name.Location = new System.Drawing.Point(4, 60);
            this.txt_city_name.Name = "txt_city_name";
            this.txt_city_name.Size = new System.Drawing.Size(161, 26);
            this.txt_city_name.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(4, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(161, 26);
            this.txt_id.TabIndex = 9;
            // 
            // ptndisplay
            // 
            this.ptndisplay.Location = new System.Drawing.Point(16, 223);
            this.ptndisplay.Name = "ptndisplay";
            this.ptndisplay.Size = new System.Drawing.Size(119, 23);
            this.ptndisplay.TabIndex = 14;
            this.ptndisplay.Text = "عرض كل المدن";
            this.ptndisplay.UseVisualStyleBackColor = true;
            this.ptndisplay.Click += new System.EventHandler(this.ptndisplay_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv);
            this.groupBox4.Location = new System.Drawing.Point(256, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 307);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "كل المدن";
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
            this.dgv.Size = new System.Drawing.Size(482, 282);
            this.dgv.TabIndex = 11;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // ptnadd
            // 
            this.ptnadd.Location = new System.Drawing.Point(13, 194);
            this.ptnadd.Name = "ptnadd";
            this.ptnadd.Size = new System.Drawing.Size(75, 23);
            this.ptnadd.TabIndex = 17;
            this.ptnadd.Text = "أضافة";
            this.ptnadd.UseVisualStyleBackColor = true;
            this.ptnadd.Click += new System.EventHandler(this.ptnadd_Click);
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(175, 194);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(75, 23);
            this.ptndelete.TabIndex = 16;
            this.ptndelete.Text = "حذف";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(94, 194);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(75, 23);
            this.ptnupdate.TabIndex = 15;
            this.ptnupdate.Text = "تعديل ";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "ألغاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormManagementCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtserach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ptndisplay);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ptnadd);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnupdate);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementCity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المدن";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtserach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_city_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button ptndisplay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ptnadd;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comContryname;
        private System.Windows.Forms.Button button1;
    }
}