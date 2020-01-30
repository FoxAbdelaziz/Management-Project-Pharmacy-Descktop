namespace Management_Project_Pharmacy.PL
{
    partial class FormRestor
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
            this.ptnrestor = new System.Windows.Forms.Button();
            this.ptnexit = new System.Windows.Forms.Button();
            this.ptnpath = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "تحديد مسار/مكان النسخة الأحتياطية ";
            // 
            // ptnrestor
            // 
            this.ptnrestor.Location = new System.Drawing.Point(77, 85);
            this.ptnrestor.Name = "ptnrestor";
            this.ptnrestor.Size = new System.Drawing.Size(191, 43);
            this.ptnrestor.TabIndex = 13;
            this.ptnrestor.Text = "أستعادة النسخة الإحتياطية";
            this.ptnrestor.UseVisualStyleBackColor = true;
            this.ptnrestor.Click += new System.EventHandler(this.ptnrestor_Click);
            // 
            // ptnexit
            // 
            this.ptnexit.Location = new System.Drawing.Point(386, 85);
            this.ptnexit.Name = "ptnexit";
            this.ptnexit.Size = new System.Drawing.Size(109, 43);
            this.ptnexit.TabIndex = 12;
            this.ptnexit.Text = "خروج";
            this.ptnexit.UseVisualStyleBackColor = true;
            this.ptnexit.Click += new System.EventHandler(this.ptnexit_Click);
            // 
            // ptnpath
            // 
            this.ptnpath.Location = new System.Drawing.Point(501, 37);
            this.ptnpath.Name = "ptnpath";
            this.ptnpath.Size = new System.Drawing.Size(53, 28);
            this.ptnpath.TabIndex = 11;
            this.ptnpath.Text = "....";
            this.ptnpath.UseVisualStyleBackColor = true;
            this.ptnpath.Click += new System.EventHandler(this.ptnpath_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(8, 36);
            this.txtpath.Name = "txtpath";
            this.txtpath.ReadOnly = true;
            this.txtpath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpath.Size = new System.Drawing.Size(487, 29);
            this.txtpath.TabIndex = 10;
            // 
            // FormRestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 137);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptnrestor);
            this.Controls.Add(this.ptnexit);
            this.Controls.Add(this.ptnpath);
            this.Controls.Add(this.txtpath);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormRestor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الخاصة باستعادة البيانات ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ptnrestor;
        private System.Windows.Forms.Button ptnexit;
        private System.Windows.Forms.Button ptnpath;
        private System.Windows.Forms.TextBox txtpath;
    }
}