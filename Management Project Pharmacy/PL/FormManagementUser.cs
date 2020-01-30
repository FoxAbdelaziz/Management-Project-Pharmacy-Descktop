using System;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementUser : Form
    {
        public FormManagementUser()
        {
            InitializeComponent();
            ptndisplay_Click(null, null);
        }
        private void ptndisplay_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClassUsers.SP_SelectAllUsers();
        }
        private void ptnadd_Click(object sender, EventArgs e)
        {
            new FormAddNewUser(false).ShowDialog();
            ptndisplay_Click(null, null);
        }
        public static DataGridViewRow row;
        private void ptnupdate_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count >0)
            {
                row = dgv.SelectedRows[0];
                new FormAddNewUser(true).ShowDialog();
                ptndisplay_Click(null, null);
            }
            else
            {
                MessageBox.Show("يجب أختيار المستخدم المراد تعديل بياناتة!","النظام",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = ClassUsers.SP_SearchUser(txtsearch.Text);
        }
        private void ptndelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                row = dgv.SelectedRows[0];
               int i = ClassUsers.SP_DeleteUser ( int.Parse(row.Cells[0].Value.ToString()));
                if (i==1)
                {
                    MessageBox.Show("تم حذف بيانات المستخدم بنجاح!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ptndisplay_Click(null, null);
            }
            else
            {
                MessageBox.Show("يجب أختيار المستخدم المراد حذف بياناتة!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}