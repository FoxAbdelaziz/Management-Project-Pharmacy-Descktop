using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewActiveMateril : Form
    {
        public FormAddNewActiveMateril()
        {
            InitializeComponent();
        }

        private void ptnadd_Click(object sender, EventArgs e)
        {
            if (txtnameactivematirel.Text == "")
            {
                MessageBox.Show("يجب أدخال أسم المادة الفعالة المراد أضافتها ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtnameactivematirel.Text ==" ")
            {
                MessageBox.Show("يجب أدخال أسم المادة الفعالة المراد أضافتها ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtnameactivematirel.Text == "  ")
            {
                MessageBox.Show("يجب أدخال أسم المادة الفعالة المراد أضافتها ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int i = ClassActiveMatrile.SP_ActiveMatrileInsert(txtnameactivematirel.Text, txtdescription.Text);
                if (i == 1)
                {
                    MessageBox.Show("تم أضافة ألمادة الفعالة بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnameactivematirel.Text = txtdescription.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtnameactivematirel_TextChanged(object sender, EventArgs e)
        {
            ptnadd.Enabled = true;
        }

        private void ptncancle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}