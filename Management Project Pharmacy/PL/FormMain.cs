using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
using Management_Project_Pharmacy.SystemControls;

using System.Drawing;

namespace Management_Project_Pharmacy.PL
{

    public partial class FormMain : Form
    {
        public static bool Check = false;
        public static int Per_ID = 0;
        public FormMain()
        {
            InitializeComponent();
            lblcom.Text = Environment.MachineName;
            lbldate.Text = DateTime.Now.ToShortDateString();
        }

        private void TclLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormLogin"] != null)
            {
                Application.OpenForms["FormLogin"].Activate();
            }
            else
            {
                FormLogin frm = new FormLogin();
                frm.ShowDialog();
            }
        }

        public void PerMation()
        {
                TclActiveMatiral.Enabled = 
                TclAddNewActiveMatiral.Enabled = 
                TclAddNewCategory.Enabled = 
                TclAddNewCustomer.Enabled = 
                TclAddNewOrder.Enabled =  
                TclAddNewProduct.Enabled = 
                TclAddNewSceitfecName.Enabled =  
                TclAddNewUser.Enabled = 
                TclBackup.Enabled = 
                TclCategoryManagement.Enabled = 
                TclCityManagement.Enabled = 
                TclCountryManagement.Enabled =
                TclCustomer.Enabled = 
                TclCustomerManagement.Enabled = 
                TclOrderManagement.Enabled = 
                TclProduct.Enabled = 
                TclProductManagement.Enabled = 
                TclRestor.Enabled = 
                TclSceinficName.Enabled = 
                TclSuppliers.Enabled =
                TclUser.Enabled = 
                TclUserManagement.Enabled = 
                TclQeury.Enabled =  
                TclFormQeury.Enabled =
                TclControls.Enabled = 
                TclSupplireManagement.Enabled = 
                TclAddNewSupplire.Enabled = 
                TclAddNewRequst.Enabled= 
                TclRequstManagement.Enabled= Check;
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            Per_ID = 0;
            if (Per_ID == 1)
            {
                PerMation();
            }
            else if (Per_ID==2)
            {
                    TclCustomer.Enabled=  TclAddNewOrder.Enabled = Check;
            }
            else if (Per_ID==0)
            {
                PerMation();
            }
            txtname.Text = Program.UserFull;
        }

        private void TclLogout_Click(object sender, EventArgs e)
        {
            if (Check == true)
            {
                Per_ID = 0;
                TclActiveMatiral.Enabled =
                    TclAddNewActiveMatiral.Enabled =
                    TclAddNewCategory.Enabled =
                    TclAddNewCustomer.Enabled =
                    TclAddNewOrder.Enabled =
                    TclAddNewProduct.Enabled =
                    TclAddNewSceitfecName.Enabled =
                    TclAddNewUser.Enabled =
                    TclBackup.Enabled =
                    TclCategoryManagement.Enabled =
                    TclCityManagement.Enabled =
                    TclCountryManagement.Enabled =
                    TclCustomer.Enabled =
                    TclCustomerManagement.Enabled =
                    TclOrderManagement.Enabled =
                    TclProduct.Enabled =
                    TclProductManagement.Enabled =
                    TclRestor.Enabled =
                    TclSceinficName.Enabled =
                    TclSuppliers.Enabled =
                    TclUser.Enabled =
                    TclUserManagement.Enabled =
                    TclQeury.Enabled =
                    TclFormQeury.Enabled =
                    TclControls.Enabled = Check = false;
                new FormLogin().ShowDialog();
            }
        }

        private void TclAddNewCategory_Click(object sender, EventArgs e)
        {
            new FormAddNewCategory().ShowDialog();
        }
        private void TclCategoryManagement_Click(object sender, EventArgs e)
        {
            new FormManagementCategory().ShowDialog();
        }

        private void TclAddNewActiveMatiral_Click(object sender, EventArgs e)
        {
            new FormAddNewActiveMateril().ShowDialog();
        }

        private void TclActiveMatiral_Click(object sender, EventArgs e)
        {
            new FormManagementAcviveMaterial().ShowDialog();
        }

        private void TclControls_Click(object sender, EventArgs e)
        {
            new FormControls().ShowDialog();
        }

        private void TclAddNewSceitfecName_Click(object sender, EventArgs e)
        {
            new FormAddNewScientifcName().ShowDialog();
        }

        private void TclSceinficName_Click(object sender, EventArgs e)
        {
            new FormManagementScientifcName().ShowDialog();
        }

        private void TclAddNewProduct_Click(object sender, EventArgs e)
        {
            new FormAddNewProduct(false).ShowDialog();
        }

        private void TclProductManagement_Click(object sender, EventArgs e)
        {
            new FormManagementProduct().ShowDialog();
        }

        private void TclAddNewSupplire_Click(object sender, EventArgs e)
        {
            new FormAddNewSupplire(true).ShowDialog();
        }

        private void TclUserManagement_Click(object sender, EventArgs e)
        {
            new FormManagementUser().ShowDialog();
        }

        private void TclFormQeury_Click(object sender, EventArgs e)
        {
            new FormQeury().ShowDialog();
        }

        private void TclSupplireManagement_Click(object sender, EventArgs e)
        {
            new FormManagementSupplire().ShowDialog();
        }

        private void TclAddNewRequst_Click(object sender, EventArgs e)
        {
            new FormAddNewPurchasse().ShowDialog();
        }

        private void TclRequstManagement_Click(object sender, EventArgs e)
        {
            new FormManagementRequste().ShowDialog();
        }

        private void TclCountryManagement_Click(object sender, EventArgs e)
        {
            new FormManagementCountry().ShowDialog();
        }

        private void TclSendMsg_Click(object sender, EventArgs e)
        {
            new FormSendMassage().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbltime.Text = DateTime.Now.ToShortTimeString();
            String r = "Massege UnRead";
            DataTable dt = ClassMassege.SP_SelectCountMsg(txtname.Text, r);
            if (dt.Rows[0][0].ToString() != "")
            {
                txtmsg.Text = dt.Rows[0][0].ToString();
                if (txtmsg.Text != "0")
                {
                    changecolor();
                }
            }
            //if (Convert.ToBoolean(timer1.Tag) == true)
            //{
            //    LabelHeader.ForeColor = Color.Red;
            //    timer1.Tag = false;
            //}
            //else
            //{
            //    LabelHeader.ForeColor = Color.White;
            //    timer1.Tag = true;
            //}
        }

        private void TclAddNewCustomer_Click(object sender, EventArgs e)
        {
            new FormAddNewCustomer(false).ShowDialog();
        }

        private void TclCityManagement_Click(object sender, EventArgs e)
        {
            new FormManagementCity().ShowDialog();
        }

        private int caseSwitch = 0;
        public void changecolor()
        {
            caseSwitch++;
            switch (caseSwitch)
            {
                case 1:
                    txtmsg.BackColor = Color.Red;
                    Console.Beep(2000, 700);
                    break;
                case 2:
                    txtmsg.BackColor = Color.White;
                    Console.Beep(2000, 700);
                    break;
            }
            if (caseSwitch == 2) caseSwitch = 0;
        }

        private void txtmsg_Click(object sender, EventArgs e)
        {
            FormShowMessage frm = new FormShowMessage();
            frm.ShowDialog();
        }

        private void TclCustomerManagement_Click(object sender, EventArgs e)
        {
            new FormManagementCustomer().ShowDialog();
        }

        private void TclAddNewOrder_Click(object sender, EventArgs e)
        {
            new FormAddNewOrder().ShowDialog();
        }

        private void TclOrderManagement_Click(object sender, EventArgs e)
        {
            new FormManagementOrder().ShowDialog();
        }

        private void TclAddNewUser_Click(object sender, EventArgs e)
        {
            new FormAddNewUser(false).ShowDialog();
        }

        private void ألخروجمنالسيستمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TclBackup_Click(object sender, EventArgs e)
        {
            new FormBackup().ShowDialog();
        }

        private void TclRestor_Click(object sender, EventArgs e)
        {
            new FormRestor().ShowDialog();
        }

        private void الةحاسبةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void نوتبادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog();
        }
    }
}