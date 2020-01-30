using System;
using System.Data;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        private void ptnbackup_Click(object sender, EventArgs e)
        {
            if (txtpath.Text == "")
            {
                MessageBox.Show("يجب اختيار مكان لحفظ النسخة !!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string Path = txtpath.Text + "\\PharmacyDB" + DateTime.Now.ToShortDateString().Replace('/', '-') + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".bak";

                    string msg= ClassBackup.Backup_DB(Path);
                    if (msg == "OK")
                    {
                        MessageBox.Show("تم أخذ نسخة من قاعدة البيانات بنجاح!!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    txtpath.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ptnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptnpath_Click(object sender, EventArgs e)
        {
            //التحقق من ان المستخدم قم بفتح الشاشة واختار مسار الحفظ
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //عرض مسار المختار فى التيكس بوكس
                txtpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
