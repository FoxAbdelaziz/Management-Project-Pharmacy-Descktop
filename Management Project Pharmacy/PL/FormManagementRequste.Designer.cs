namespace Management_Project_Pharmacy.PL
{
    partial class FormManagementRequste
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
            this.ptnDispaly = new System.Windows.Forms.Button();
            this.ptnExit = new System.Windows.Forms.Button();
            this.ptnPrint = new System.Windows.Forms.Button();
            this.ptndelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(1, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كل فواتير الشراء";
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
            this.dgv.Size = new System.Drawing.Size(929, 282);
            this.dgv.TabIndex = 0;
            // 
            // ptnDispaly
            // 
            this.ptnDispaly.Location = new System.Drawing.Point(143, 323);
            this.ptnDispaly.Name = "ptnDispaly";
            this.ptnDispaly.Size = new System.Drawing.Size(121, 23);
            this.ptnDispaly.TabIndex = 1;
            this.ptnDispaly.Text = "عرض كل الفواتير ";
            this.ptnDispaly.UseVisualStyleBackColor = true;
            this.ptnDispaly.Click += new System.EventHandler(this.ptnDispaly_Click);
            // 
            // ptnExit
            // 
            this.ptnExit.Location = new System.Drawing.Point(611, 320);
            this.ptnExit.Name = "ptnExit";
            this.ptnExit.Size = new System.Drawing.Size(75, 23);
            this.ptnExit.TabIndex = 2;
            this.ptnExit.Text = "خروج";
            this.ptnExit.UseVisualStyleBackColor = true;
            this.ptnExit.Click += new System.EventHandler(this.ptnExit_Click);
            // 
            // ptnPrint
            // 
            this.ptnPrint.Location = new System.Drawing.Point(285, 323);
            this.ptnPrint.Name = "ptnPrint";
            this.ptnPrint.Size = new System.Drawing.Size(149, 23);
            this.ptnPrint.TabIndex = 3;
            this.ptnPrint.Text = "طباعه الفاتورة المحددة";
            this.ptnPrint.UseVisualStyleBackColor = true;
            this.ptnPrint.Click += new System.EventHandler(this.ptnPrint_Click);
            // 
            // ptndelete
            // 
            this.ptndelete.Location = new System.Drawing.Point(451, 321);
            this.ptndelete.Name = "ptndelete";
            this.ptndelete.Size = new System.Drawing.Size(154, 23);
            this.ptndelete.TabIndex = 4;
            this.ptndelete.Text = "حذف الفاتورة المحددة";
            this.ptndelete.UseVisualStyleBackColor = true;
            // 
            // FormManagementRequste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 352);
            this.Controls.Add(this.ptndelete);
            this.Controls.Add(this.ptnPrint);
            this.Controls.Add(this.ptnExit);
            this.Controls.Add(this.ptnDispaly);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementRequste";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة فواتير المشتريات";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ptnDispaly;
        private System.Windows.Forms.Button ptnExit;
        private System.Windows.Forms.Button ptnPrint;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ptndelete;
    }
}