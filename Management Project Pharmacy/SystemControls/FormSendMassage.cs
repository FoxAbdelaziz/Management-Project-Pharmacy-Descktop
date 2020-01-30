using System;
using System.Data;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.SystemControls
{
    public partial class FormSendMassage : Form
    {
        public FormSendMassage()
        {
            InitializeComponent();
            FormSendMassage_Load(null, null);
        }

        private void FormSendMassage_Load(object sender, EventArgs e)
        {
            lstall.DataSource = ClassLogin.SP_SelectAllUsers();
            lstall.DisplayMember = "أسم المستخدم";
            lstall.ValueMember = "أسم المستخدم";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < lstall.Items.Count; i++)
                {
                    lstall.SetItemChecked(i,true);
                }
            }
            else
            {
                for (int i = 0; i < lstall.Items.Count; i++)
                {
                    lstall.SetItemChecked(i, false);
                }
            }
        }

        private void ptnsendmsg_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstall.CheckedItems.Count; i++)
            {
                ;
               string msgread="Massege UnRead";
               int In= ClassMassege.SP_InsertMasege(txtmsgtitla.Text,txtmsgdetails.Text,DateTime.Now,lstall.SelectedValue.ToString(), msgread);
                if (In == 1)
                    MessageBox.Show("تم أرسال الرسائل بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstall.SelectedValue.ToString());
        }

        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
