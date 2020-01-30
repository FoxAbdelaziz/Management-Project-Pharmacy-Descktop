using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewCategory : Form
    {
        public FormAddNewCategory()
        {
            InitializeComponent();
        }

        private void ptncancle_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ptnadd_Click(object sender, EventArgs e)
        {
            if (txtcatogry.Text == "")
            {
                MessageBox.Show("يجب أدخال أسم الصنف المراد اضافته", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int ist = ClassCategory.SP_InsertCategory(txtcatogry.Text);
                if (ist==1)
                {
                    MessageBox.Show("تم أضافة الصنف بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcatogry.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(" ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcatogry.Text = string.Empty;
                }          
            }
        }
        private void txtcatogry_TextChanged(object sender, EventArgs e)
        {
            ptnadd.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}