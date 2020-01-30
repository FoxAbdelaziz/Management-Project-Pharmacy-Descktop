using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ptnloguser_Click(object sender, EventArgs e)
        {
            string Process = "";
            if (txtusernam.Text == string.Empty)
            {
                MessageBox.Show("يجب أدخال أسم المستخدم", "  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtpass.Text == string.Empty)
            {
                MessageBox.Show("يجب أدخال كلمة المرور", "  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataTable dt = ClassLogin.SP_Login(txtusernam.Text, txtpass.Text);
                if (dt.Rows.Count > 0)
                {
                    Process = "العملية نجحت بالدخول";
                    int i = ClassLogin.SP_ControlInsert(txtusernam.Text, txtpass.Text, DateTime.Now, Process);
                    PL.FormMain.Per_ID = int.Parse( dt.Rows[0]["Per_ID"].ToString());
                    PL.FormMain.Check = true;
                    Program.UserFull = dt.Rows[0]["U_FullName"].ToString();
                    this.Close();
                }
                else
                {
                    Process = "العملية فشلت بالدخول";
                    int i = ClassLogin.SP_ControlInsert(txtusernam.Text, txtpass.Text, DateTime.Now, Process);
                    MessageBox.Show("أسم المستخدم أو كلمة المرور غالط", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtpass.Text = txtusernam.Text = string.Empty;
                }
            }
        }

        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}