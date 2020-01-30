using System;
using System.Data;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementCountry : Form
    {
        public FormManagementCountry()
        {
            InitializeComponent();
            ptndisplay_Click(null, null);
        }

        private void ptnadd_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("يجب أدخال أسم الدولة", "النظام", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                int i = ClassCountry.SP_InsertCountry(txtcodecountry.Text, txt_name.Text);
                if (i == 1)
                {
                    MessageBox.Show("تم أضافة الدولة بنجاح", "النظام", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txt_name.Text = txt_id.Text = txtcodecountry.Text = "";

                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    txt_name.Text = txt_id.Text = txtcodecountry.Text = "";
                }
                ptndisplay_Click(null, null);
            }
        }

        private void ptndisplay_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClassCountry.SP_SelectAllCountry();
        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = ClassCountry.SP_SearchCountry(txtserach.Text);
        }

        private void ptnupdate_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("يجب أدخال أسم الدولة المرادا تعديلها", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int i = ClassCountry.SP_UpdateCountry(int.Parse(txt_id.Text), txtcodecountry.Text, txt_name.Text);
                if (i == 1)
                {
                    MessageBox.Show("تم تعديل الدولة بنجاح!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_name.Text = txt_id.Text = txtcodecountry.Text = "";

                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_name.Text = txt_id.Text = txtcodecountry.Text = "";

                }
                ptndisplay_Click(null, null);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                txt_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                txtcodecountry.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                txt_name.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void FormManagementCountry_Load(object sender, EventArgs e)
        {

        }

        private void ptndelete_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("يجب أدخال أسم الدولة المرادا حذفها", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int i = ClassCountry.SP_DeleteCountry(int.Parse(txt_id.Text));
                if (i == 1)
                {
                    MessageBox.Show("تم حذف الدولة بنجاح!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_name.Text = txt_id.Text = txtcodecountry.Text = "";
                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_name.Text = txt_id.Text = txtcodecountry.Text = "";
                }
                ptndisplay_Click(null, null);
            }
        }

        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}