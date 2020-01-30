namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementCustomer
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptndelete = new System.Windows.Forms.Button();
            this.ptndisplay = new System.Windows.Forms.Button();
            this.ptnadd = new System.Windows.Forms.Button();
            this.ptnupdate = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.نسخToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لصقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أحصائياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أحصائيةبالعملاءالجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.أحصائيةبالعملاءمنشهرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.أحصائيةبالعملاءمنشهرينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أحصائيةبالعملاءمنسنةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv.Size = new System.Drawing.Size(870, 324);
            this.dgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كل بيانات العملاء";
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(590, 425);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(170, 23);
            this.ptndelete.TabIndex = 2;
            this.ptndelete.Text = "حذف بيانات العميل المحدد";
            this.ptndelete.UseVisualStyleBackColor = true;
            this.ptndelete.Click += new System.EventHandler(this.ptndelete_Click);
            // 
            // ptndisplay
            // 
            this.ptndisplay.Location = new System.Drawing.Point(52, 425);
            this.ptndisplay.Name = "ptndisplay";
            this.ptndisplay.Size = new System.Drawing.Size(170, 23);
            this.ptndisplay.TabIndex = 3;
            this.ptndisplay.Text = "عرض كل العملاء";
            this.ptndisplay.UseVisualStyleBackColor = true;
            this.ptndisplay.Click += new System.EventHandler(this.ptndisplay_Click);
            // 
            // ptnadd
            // 
            this.ptnadd.Location = new System.Drawing.Point(228, 425);
            this.ptnadd.Name = "ptnadd";
            this.ptnadd.Size = new System.Drawing.Size(170, 23);
            this.ptnadd.TabIndex = 4;
            this.ptnadd.Text = "إضافة عميل جديد";
            this.ptnadd.UseVisualStyleBackColor = true;
            this.ptnadd.Click += new System.EventHandler(this.ptnadd_Click);
            // 
            // ptnupdate
            // 
            this.ptnupdate.Location = new System.Drawing.Point(407, 425);
            this.ptnupdate.Name = "ptnupdate";
            this.ptnupdate.Size = new System.Drawing.Size(170, 23);
            this.ptnupdate.TabIndex = 5;
            this.ptnupdate.Text = "تعديل بيانات العميل المحدد";
            this.ptnupdate.UseVisualStyleBackColor = true;
            this.ptnupdate.Click += new System.EventHandler(this.ptnupdate_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(232, 37);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(598, 26);
            this.txtsearch.TabIndex = 6;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "الكلمة المراد البحث عنها ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.أحصائياتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem,
            this.toolStripSeparator1,
            this.نسخToolStripMenuItem,
            this.لصقToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // نسخToolStripMenuItem
            // 
            this.نسخToolStripMenuItem.Name = "نسخToolStripMenuItem";
            this.نسخToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.نسخToolStripMenuItem.Text = "نسخ";
            // 
            // لصقToolStripMenuItem
            // 
            this.لصقToolStripMenuItem.Name = "لصقToolStripMenuItem";
            this.لصقToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.لصقToolStripMenuItem.Text = "لصق";
            // 
            // أحصائياتToolStripMenuItem
            // 
            this.أحصائياتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.أحصائيةبالعملاءالجديدToolStripMenuItem,
            this.toolStripSeparator3,
            this.أحصائيةبالعملاءمنشهرToolStripMenuItem,
            this.toolStripSeparator2,
            this.أحصائيةبالعملاءمنشهرينToolStripMenuItem,
            this.أحصائيةبالعملاءمنسنةToolStripMenuItem});
            this.أحصائياتToolStripMenuItem.Name = "أحصائياتToolStripMenuItem";
            this.أحصائياتToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.أحصائياتToolStripMenuItem.Text = "أحصائيات";
            // 
            // أحصائيةبالعملاءالجديدToolStripMenuItem
            // 
            this.أحصائيةبالعملاءالجديدToolStripMenuItem.Name = "أحصائيةبالعملاءالجديدToolStripMenuItem";
            this.أحصائيةبالعملاءالجديدToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.أحصائيةبالعملاءالجديدToolStripMenuItem.Text = "أحصائية بالعملاء الجديد";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // أحصائيةبالعملاءمنشهرToolStripMenuItem
            // 
            this.أحصائيةبالعملاءمنشهرToolStripMenuItem.Name = "أحصائيةبالعملاءمنشهرToolStripMenuItem";
            this.أحصائيةبالعملاءمنشهرToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.أحصائيةبالعملاءمنشهرToolStripMenuItem.Text = "أحصائية بالعملاء من شهر";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(225, 6);
            // 
            // أحصائيةبالعملاءمنشهرينToolStripMenuItem
            // 
            this.أحصائيةبالعملاءمنشهرينToolStripMenuItem.Name = "أحصائيةبالعملاءمنشهرينToolStripMenuItem";
            this.أحصائيةبالعملاءمنشهرينToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.أحصائيةبالعملاءمنشهرينToolStripMenuItem.Text = "أحصائية بالعملاء من شهرين";
            // 
            // أحصائيةبالعملاءمنسنةToolStripMenuItem
            // 
            this.أحصائيةبالعملاءمنسنةToolStripMenuItem.Name = "أحصائيةبالعملاءمنسنةToolStripMenuItem";
            this.أحصائيةبالعملاءمنسنةToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.أحصائيةبالعملاءمنسنةToolStripMenuItem.Text = "أحصائية بالعملاء من سنة";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(766, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormManagementCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.ptnupdate);
            this.Controls.Add(this.ptnadd);
            this.Controls.Add(this.ptndisplay);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة العملاء";
            this.Activated += new System.EventHandler(this.FormManagementCustomer_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ptndelete;
        private System.Windows.Forms.Button ptndisplay;
        private System.Windows.Forms.Button ptnadd;
        private System.Windows.Forms.Button ptnupdate;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أحصائياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أحصائيةبالعملاءالجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أحصائيةبالعملاءمنشهرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أحصائيةبالعملاءمنشهرينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem نسخToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لصقToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem أحصائيةبالعملاءمنسنةToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}