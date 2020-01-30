using System;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormRestor : Form
    {
        public FormRestor()
        {
            InitializeComponent();
        }

        private void ptnrestor_Click(object sender, EventArgs e)
        {
            try
            {
                ClassBackup.Restor_DB(txtpath.Text);
                MessageBox.Show("تم أستعادة البيانات بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpath.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ptnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptnpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //التحقق من ان المستخدم قم بفتح الشاشة واختار مسار الحفظ
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //عرض مسار المختار فى التيكس بوكس
                txtpath.Text = ofd.FileName;
            }
        }
    }
}