namespace Management_Project_Pharmacy.SystemControls
{
    partial class FormSendMassage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmsgtitla = new System.Windows.Forms.TextBox();
            this.txtmsgdetails = new System.Windows.Forms.TextBox();
            this.ptnsendmsg = new System.Windows.Forms.Button();
            this.ptnclose = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lstall = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "الشاشة الخاصة بأرسال الرسائل للموظفين\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "عنوان الرسالة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "تفاصيل الرسالة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "المراد أرسال لة الرسالة";
            // 
            // txtmsgtitla
            // 
            this.txtmsgtitla.Location = new System.Drawing.Point(130, 72);
            this.txtmsgtitla.Name = "txtmsgtitla";
            this.txtmsgtitla.Size = new System.Drawing.Size(415, 29);
            this.txtmsgtitla.TabIndex = 5;
            // 
            // txtmsgdetails
            // 
            this.txtmsgdetails.Location = new System.Drawing.Point(130, 112);
            this.txtmsgdetails.Multiline = true;
            this.txtmsgdetails.Name = "txtmsgdetails";
            this.txtmsgdetails.Size = new System.Drawing.Size(415, 78);
            this.txtmsgdetails.TabIndex = 6;
            // 
            // ptnsendmsg
            // 
            this.ptnsendmsg.Location = new System.Drawing.Point(47, 343);
            this.ptnsendmsg.Name = "ptnsendmsg";
            this.ptnsendmsg.Size = new System.Drawing.Size(234, 40);
            this.ptnsendmsg.TabIndex = 14;
            this.ptnsendmsg.Text = "أرسائل الرسائل";
            this.ptnsendmsg.UseVisualStyleBackColor = true;
            this.ptnsendmsg.Click += new System.EventHandler(this.ptnsendmsg_Click);
            // 
            // ptnclose
            // 
            this.ptnclose.Location = new System.Drawing.Point(287, 344);
            this.ptnclose.Name = "ptnclose";
            this.ptnclose.Size = new System.Drawing.Size(234, 40);
            this.ptnclose.TabIndex = 15;
            this.ptnclose.Text = "خروج";
            this.ptnclose.UseVisualStyleBackColor = true;
            this.ptnclose.Click += new System.EventHandler(this.ptnclose_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(189, 205);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 26);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "تحديد الكل";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lstall
            // 
            this.lstall.FormattingEnabled = true;
            this.lstall.Location = new System.Drawing.Point(284, 203);
            this.lstall.Name = "lstall";
            this.lstall.Size = new System.Drawing.Size(261, 124);
            this.lstall.TabIndex = 18;
            // 
            // FormSendMassage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 396);
            this.Controls.Add(this.lstall);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ptnclose);
            this.Controls.Add(this.ptnsendmsg);
            this.Controls.Add(this.txtmsgdetails);
            this.Controls.Add(this.txtmsgtitla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FormSendMassage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الخاصة بأرسال الرسائل";
            this.Load += new System.EventHandler(this.FormSendMassage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmsgtitla;
        private System.Windows.Forms.TextBox txtmsgdetails;
        private System.Windows.Forms.Button ptnsendmsg;
        private System.Windows.Forms.Button ptnclose;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox lstall;
    }
}