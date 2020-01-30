namespace Management_Project_Pharmacy.BL
{
    partial class FormManagementOrder
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
            this.ptnPrint = new System.Windows.Forms.Button();
            this.ptnExit = new System.Windows.Forms.Button();
            this.ptnDispaly = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فواتير البيع";
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
            this.dgv.Size = new System.Drawing.Size(740, 282);
            this.dgv.TabIndex = 0;
            // 
            // ptnPrint
            // 
            this.ptnPrint.Location = new System.Drawing.Point(317, 325);
            this.ptnPrint.Name = "ptnPrint";
            this.ptnPrint.Size = new System.Drawing.Size(149, 23);
            this.ptnPrint.TabIndex = 7;
            this.ptnPrint.Text = "طباعه الفاتورة المحددة";
            this.ptnPrint.UseVisualStyleBackColor = true;
            // 
            // ptnExit
            // 
            this.ptnExit.Location = new System.Drawing.Point(490, 325);
            this.ptnExit.Name = "ptnExit";
            this.ptnExit.Size = new System.Drawing.Size(75, 23);
            this.ptnExit.TabIndex = 6;
            this.ptnExit.Text = "خروج";
            this.ptnExit.UseVisualStyleBackColor = true;
            this.ptnExit.Click += new System.EventHandler(this.ptnExit_Click);
            // 
            // ptnDispaly
            // 
            this.ptnDispaly.Location = new System.Drawing.Point(175, 325);
            this.ptnDispaly.Name = "ptnDispaly";
            this.ptnDispaly.Size = new System.Drawing.Size(121, 23);
            this.ptnDispaly.TabIndex = 5;
            this.ptnDispaly.Text = "عرض كل الفواتير ";
            this.ptnDispaly.UseVisualStyleBackColor = true;
            this.ptnDispaly.Click += new System.EventHandler(this.ptnDispaly_Click);
            // 
            // FormManagementOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptnPrint);
            this.Controls.Add(this.ptnExit);
            this.Controls.Add(this.ptnDispaly);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FormManagementOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة فواتير البيع";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button ptnPrint;
        private System.Windows.Forms.Button ptnExit;
        private System.Windows.Forms.Button ptnDispaly;
    }
}