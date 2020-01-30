using System;
using System.Data;

using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();
            FormControls_Load(null, null);
        }

        private void FormControls_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClassLogin.SP_SelectAllControls();
            dgv.DataSource = dt;
        }

        private void PtnDelete_Click(object sender, EventArgs e)
        {
            int i =ClassLogin.SP_DeleteControls();
            if (i==1)
            {
                MessageBox.Show("تم حذف كل البيانات بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FormControls_Load(null, null);
            }
        }

        private void FormControls_Activated(object sender, EventArgs e)
        {
            FormControls_Load(null, null);
        }
    }
}
