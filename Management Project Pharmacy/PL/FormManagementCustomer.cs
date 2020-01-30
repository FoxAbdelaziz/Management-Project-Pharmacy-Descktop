using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementCustomer : Form
    {
        public FormManagementCustomer()
        {
            InitializeComponent();
            FormManagementCustomer_Activated(null, null);
        }

        public static DataGridViewRow Row = null;


        private void ptnadd_Click(object sender, EventArgs e)
        {
            new FormAddNewCustomer(false).ShowDialog();
        }

        private void ptnupdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
                Row= dgv.SelectedRows[0];
            else MessageBox.Show("يجب أختيار العميل المراد تعديل بياناته!","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            new FormAddNewCustomer(true).ShowDialog();

        }

        private void ptndisplay_Click(object sender, EventArgs e)
        {
            FormManagementCustomer_Activated(null,null);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = ClassCustomer.SP_SearchCustomer(txtsearch.Text);
            EditeImage();
        }

        private void EditeImage()
        {
            //dgv.Columns[4].Width = 80;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col is DataGridViewImageColumn)
                    ((DataGridViewImageColumn)col).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                dr.Height = 100;
            }
        }

        private void FormManagementCustomer_Activated(object sender, EventArgs e)
        {
            dgv.DataSource = ClassCustomer.SP_SelectAllCustomer();
            EditeImage();
        }

        private void ptndelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                Row = dgv.SelectedRows[0];
           int i=     ClassCustomer.SP_DeleteCustomer(int.Parse(FormManagementCustomer.Row.Cells[0].Value.ToString()));
                if (i==1)
                    MessageBox.Show("تم حذف بيانات العميل بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("يجب أختيار العميل المراد حذف بياناته!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}