using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementAcviveMaterial : Form
    {
        public FormManagementAcviveMaterial()
        {
            InitializeComponent();
            ptnselectall_Click(null, null);
        }

        private void ptnselectall_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ClassActiveMatrile.SP_SelectAallActiveMatrile();
            dgv.DataSource = dt;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                txtAm_ID.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAm_Name.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAm_Description.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassActiveMatrile.SP_SearchActiveMatrile(txtsearch.Text);
            dgv.DataSource = dt;
        }

        private void ptnupdate_Click(object sender, EventArgs e)
        {
            if (txtAm_Name.Text=="")
            {
                MessageBox.Show("يجب أدخال أسم المادة الفعالة المراد تعديلها","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            int i = ClassActiveMatrile.SP_UpdateActvieMatirel(int.Parse(txtAm_ID.Text),txtAm_Name.Text,txtAm_Description.Text);
            if (i==1)
            {
                MessageBox.Show("تم تعديل بيانات المادة الفعالة بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtAm_ID.Text = txtAm_Name.Text = txtAm_Description.Text = string.Empty ;
            }
            else
            {
                MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAm_ID.Text = txtAm_Name.Text = txtAm_Description.Text = string.Empty;
            }
            ptnselectall_Click(null, null);

        }

        private void ptndelete_Click(object sender, EventArgs e)
        {
            if (txtAm_ID.Text=="" &txtAm_Name.Text=="")
            {
                MessageBox.Show("يجب أختيار أسم المادة الفعالة المراد حذفها","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            int i=  ClassActiveMatrile.SP_DeleteActiveMatrile(int.Parse(txtAm_ID.Text));
            if (i==1)
            {
                MessageBox.Show("تم حذف المادة الفعالة بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtAm_ID.Text = txtAm_Name.Text = txtAm_Description.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtAm_ID.Text = txtAm_Name.Text = txtAm_Description.Text = string.Empty;
            }
            ptnselectall_Click(null, null);
        }

        private void FormManagementAcviveMaterial_Load(object sender, EventArgs e)
        {

        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblcount.Text = dgv.Rows.Count.ToString();
        }

        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}