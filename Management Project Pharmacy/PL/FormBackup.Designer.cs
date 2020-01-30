namespace Management_Project_Pharmacy.PL
{
    partial class FormBackup
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
            this.label1 = new System.Windows.Forms.Label();
            this.ptnbackup = new System.Windows.Forms.Button();
            this.ptnexit = new System.Windows.Forms.Button();
            this.ptnpath = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "تحديد مسار/مكان حفظ النسخة الأحتياطية ";
            // 
            // ptnbackup
            // 
            this.ptnbackup.Location = new System.Drawing.Point(76, 96);
            this.ptnbackup.Name = "ptnbackup";
            this.ptnbackup.Size = new System.Drawing.Size(191, 43);
            this.ptnbackup.TabIndex = 8;
            this.ptnbackup.Text = "انشاء نسخة أحتياطية";
            this.ptnbackup.UseVisualStyleBackColor = true;
            this.ptnbackup.Click += new System.EventHandler(this.ptnbackup_Click);
            // 
            // ptnexit
            // 
            this.ptnexit.Location = new System.Drawing.Point(385, 96);
            this.ptnexit.Name = "ptnexit";
            this.ptnexit.Size = new System.Drawing.Size(109, 43);
            this.ptnexit.TabIndex = 7;
            this.ptnexit.Text = "خروج";
            this.ptnexit.UseVisualStyleBackColor = true;
            this.ptnexit.Click += new System.EventHandler(this.ptnexit_Click);
            // 
            // ptnpath
            // 
            this.ptnpath.Location = new System.Drawing.Point(500, 48);
            this.ptnpath.Name = "ptnpath";
            this.ptnpath.Size = new System.Drawing.Size(53, 28);
            this.ptnpath.TabIndex = 6;
            this.ptnpath.Text = "....";
            this.ptnpath.UseVisualStyleBackColor = true;
            this.ptnpath.Click += new System.EventHandler(this.ptnpath_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(7, 47);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpath.Size = new System.Drawing.Size(487, 29);
            this.txtpath.TabIndex = 5;
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptnbackup);
            this.Controls.Add(this.ptnexit);
            this.Controls.Add(this.ptnpath);
            this.Controls.Add(this.txtpath);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormBackup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الخاصة بأخذ نسخة أحطياطية من قاعدة البيانات ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ptnbackup;
        private System.Windows.Forms.Button ptnexit;
        private System.Windows.Forms.Button ptnpath;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}