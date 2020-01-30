using System;
using System.Data;
using Management_Project_Pharmacy.BL;

using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementScientifcName : Form
    {
        public FormManagementScientifcName()
        {
            InitializeComponent();
            ptnselectall_Click(null, null);
        }

        private void ptnselectall_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClassSecintificName.SP_SelectAllSecintificName();
            dgv.DataSource = dt;
        }

        private void FormManagementScientifcName_Activated(object sender, EventArgs e)
        {
            ptnselectall_Click(null, null);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtsnid.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtsnname.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt= ClassSecintificName.SP_SearchSecintificName(txtsearch.Text);
            dgv.DataSource = dt;
        }

        private void ptnupdate_Click(object sender, EventArgs e)
        {
            if (txtsnname.Text==string.Empty)
            {
                MessageBox.Show("يجب أختيار أسم العلمى المراد تعديلة","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                ;
                int i = ClassSecintificName.SP_UpdateSecintifcName(int.Parse(txtsnid.Text),txtsnname.Text);
                if (i==1)
                {
                    MessageBox.Show("تم تعديل البيانات بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtsnid.Text = txtsnname.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtsnid.Text = txtsnname.Text = string.Empty;
                }
                ptnselectall_Click(null, null);

            }
        }

        private void ptndelete_Click(object sender, EventArgs e)
        {
            if (txtsnname.Text == string.Empty)
            {
                MessageBox.Show("يجب أختيار أسم العملى المراد حذفة","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                int i=ClassSecintificName.SP_DeleteSecintifcName(int.Parse(txtsnid.Text));
                if (i==1)
                {
                    MessageBox.Show("تم حذف الأسم العلمى بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtsnid.Text = txtsnname.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsnid.Text = txtsnname.Text = string.Empty;

                }
                ptnselectall_Click(null, null);

            }
        }

        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}