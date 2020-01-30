using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementSupplire : Form
    {
        public FormManagementSupplire()
        {
            InitializeComponent();
            ptndisplay_Click(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcount.Text = dgv.Rows.Count.ToString();
        }

        private void ptndisplay_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassSupplire.SP_SelcetAllSupplier();
            dgv.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassSupplire.SP_SearchSupplier(txtsearch.Text);
            dgv.DataSource = dt;
        }

        private void ptnadd_Click(object sender, EventArgs e)
        {
            new FormAddNewSupplire(true).ShowDialog();
            ptndisplay_Click(null, null);
        }

        private void ptnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int Su_ID;
        private void ptnupdate_Click(object sender, EventArgs e)
        {
            Su_ID = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
            new FormAddNewSupplire(false).ShowDialog();
            ptndisplay_Click(null, null);
        }

        private void ptndelete_Click(object sender, EventArgs e)
        {
            Su_ID = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
            int i = ClassSupplire.SP_DeleteSupllire(Su_ID);
            if (i==1)
            {
                MessageBox.Show("تم حذف بيانات المورد بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ptndisplay_Click(null, null);
        }
    }
}
