using System;
using System.Data;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementCategory : Form
    {
        public FormManagementCategory()
        {
            InitializeComponent();
            ptnselectall_Click(null, null);
        }
        private void ptnselectall_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClassCategory.SP_SelectAllCategory();
            dgv.DataSource=dt;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtcatid.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtcatname.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }                    
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClassCategory.SP_SearchCategory(txtsearch.Text);
            dgv.DataSource = dt;
        }

        private void ptnupdate_Click(object sender, EventArgs e)
        {
            if (txtcatname.Text == "")
            {
                MessageBox.Show("يجب أدخال أسم الصنف المراد تعديلة", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int i = ClassCategory.SP_UpdateCategory(txtcatname.Text,int.Parse(txtcatid.Text));
                if (i==1)
                {
                    MessageBox.Show("تم تعديل الصنف بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   txtcatid.Text= txtcatname.Text = "";
                    ptnselectall_Click(null, null);

                }
                else
                {
                    MessageBox.Show(" ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcatid.Text = txtcatname.Text = "";
                    ptnselectall_Click(null, null);

                }
            }      
        }

        private void ptndelete_Click(object sender, EventArgs e)
        {
            if (txtcatid.Text == "" & txtcatname.Text == "")
            {
                MessageBox.Show("يجب أختيار أسم الصنف المراد حذفة", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                int i = ClassCategory.SP_DeleteCategory(int.Parse(txtcatid.Text));
                if (i==1)
                {
                    MessageBox.Show("تم حذف الصنف بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtcatid.Text = txtcatname.Text = "";
                    ptnselectall_Click(null, null);
                }
                else
                {
                    MessageBox.Show(" ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcatid.Text = txtcatname.Text = "";
                    ptnselectall_Click(null, null);
                }
            }

        }

        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
