using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewScientifcName : Form
    {
        public FormAddNewScientifcName()
        {
            InitializeComponent();
        }

        private void ptnadd_Click(object sender, EventArgs e)
        {
            if (txtsnname.Text=="")
            {
                MessageBox.Show("يجب أدخال أسم العلمى المراد اضافته","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int i = ClassSecintificName.SP_InsertSecintificName(txtsnname.Text);
                if (i==1)
                {
                    MessageBox.Show("تم  أضافة الأسم العلمة بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtsnname.Text = string.Empty;
                }
                else {
                    MessageBox.Show("","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtsnname.Text = string.Empty;

                }
            }
        }

        private void ptncancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}