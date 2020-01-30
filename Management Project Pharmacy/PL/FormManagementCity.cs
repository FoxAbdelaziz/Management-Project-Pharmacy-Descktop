using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementCity : Form
    {
        public FormManagementCity()
        {
            InitializeComponent();
            comContryname.DataSource = ClassCountry.SP_SelectAllCountry();
            comContryname.DisplayMember = "أسم الدولة";
            comContryname.ValueMember = "معرف الدولة";

            ptndisplay_Click(null, null);
        }

        private void ptnadd_Click(object sender, EventArgs e)
        {
            if (txt_city_name.Text == "")
                MessageBox.Show("يجب أدخال أسم المدينة", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int i = ClassCity.SP_InsertCity(txt_city_name.Text, (int)comContryname.SelectedValue);
                if (i == 1)
                {
                    MessageBox.Show("تم اضافة المدينة بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_city_name.Text = txt_id.Text = "";
                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_city_name.Text = txt_id.Text = "";
                }
                ptndisplay_Click(null, null);
            }
        }

        private void ptndisplay_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClassCity.SP_SelectAllCity();
        }

        private void txtserach_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = ClassCity.SP_SearchCity(txtserach.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void ptnupdate_Click(object sender, EventArgs e)
        {
            if (txt_city_name.Text == "")
                MessageBox.Show("  يجب أدخال أسم المدينة المراد تعديلها", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int i = ClassCity.SP_UpdateCity(int.Parse(txt_id.Text), txt_city_name.Text, (int)comContryname.SelectedValue);
                if (i == 1)
                {
                    MessageBox.Show("تم تعديل المدينة بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_city_name.Text = txt_id.Text = "";
                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_city_name.Text = txt_id.Text = "";
                }
                ptndisplay_Click(null, null);
            }
        }

        private void ptndelete_Click(object sender, EventArgs e)
        {
            int i = ClassCity.SP_DeleteCity(int.Parse(txt_id.Text));
            if (i == 1)
            {
                MessageBox.Show("تم حذف المدينة بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_city_name.Text = txt_id.Text = "";
            }
            else
            {
                MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_city_name.Text = txt_id.Text = "";
            }
            ptndisplay_Click(null, null);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count>0)
            {
                txt_id.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
                txt_city_name.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
                comContryname.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();

            }

        }
    }
}