using System;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewUser : Form
    {
        bool IsUpdate;
        public FormAddNewUser(bool _IsUpdate)
        {
            InitializeComponent();
            com_per_id.DataSource = ClassUsers.SP_SelectAllPermation();
            com_per_id.DisplayMember = "Per_Name";
            com_per_id.ValueMember = "Per_ID";

            this.IsUpdate = _IsUpdate;
            if (IsUpdate)
            {
                this.Text = "تعديل بيانات المستخدم";
                ptn.Text = "تعديل";
                txt_u_name.Text = FormManagementUser.row.Cells[1].Value.ToString();
                txt_u_pass.Text = FormManagementUser.row.Cells[2].Value.ToString();
                txt_u_full_name.Text = FormManagementUser.row.Cells[3].Value.ToString();
                com_per_id.Text = FormManagementUser.row.Cells[4].Value.ToString();
            }
            else
            {
                this.Text = "أضافة بيانات المستخدم";
                ptn.Text = "أضافة";
            }
        }
        private void ptn_Click(object sender, EventArgs e)
        {
            if (txt_u_name.Text == "" || txt_u_pass.Text == "")
            {
                MessageBox.Show("يجب أدخال أسم المستخدم وكلمة المرور", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_cheek_u_pass.Text != txt_u_pass.Text)
            {
                MessageBox.Show("عفواً كلمة المرور غير مطابقة ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_u_full_name.Text == "")
            {
                MessageBox.Show("يجب أدخال الأسم بالكامل", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IsUpdate)
            {
                int i = ClassUsers.SP_UpdateUser(int.Parse(FormManagementUser.row.Cells[0].Value.ToString()),txt_u_name.Text, txt_u_pass.Text, txt_u_full_name.Text, int.Parse(com_per_id.SelectedValue.ToString()));
                if (i == 1)
                    MessageBox.Show("تم تعديل بيانات المستخدم بنجأح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foreach (Control cont in groupBox1.Controls)
                {
                    if (cont is TextBox)
                    {
                        cont.Text = "";
                    }
                }
            }
            else
            {
                int i = ClassUsers.SP_InsertUser(txt_u_name.Text, txt_u_pass.Text, txt_u_full_name.Text, int.Parse(com_per_id.SelectedValue.ToString()));
                if (i == 1)
                    MessageBox.Show("تم أضافة المستخدم بنجأح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foreach (Control cont in groupBox1.Controls)
                {
                    if (cont is TextBox)
                    {
                        cont.Text = "";
                    }
                }
            }
        }
    }
}