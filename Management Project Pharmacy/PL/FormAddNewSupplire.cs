using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewSupplire : Form
    {
        bool _Check=true;
        public FormAddNewSupplire(bool Check)
        {
            InitializeComponent();
            _Check = Check;
            if (_Check)
            {
                this.Text = "الشاشة الخاصة بأضافة بيانات الموردين";
                ptnadd.Text = "أضافة";          
            }
            else
            {
                this.Text = "الشاشة الخاصة بتعديل بيانات الموردين";
                ptnadd.Text = "تعديل";
                DataTable dt = ClassSupplire.SP_SelectByIDSupplire(FormManagementSupplire.Su_ID);
                foreach (DataRow dr in dt.Rows)
                {
                    txtnamesuppl.Text = dr["Su_Name"].ToString();
                    txtmobile.Text = dr["Su_Mobile"].ToString();
                }
            }
        }

        private void ptnadd_Click(object sender, EventArgs e)
        {
            if (_Check)
            {
                if (txtnamesuppl.Text == "" && txtmobile.Text=="")
                {
                    MessageBox.Show("يجد أدخال أسم المورد ورقم المحمول","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    int i = ClassSupplire.SP_InsertSupplire(txtnamesuppl.Text, txtmobile.Text);
                    if (i == 1)
                    {
                        MessageBox.Show("تم أضافة بيانات المورد بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtmobile.Text = txtnamesuppl.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtmobile.Text = txtnamesuppl.Text = string.Empty;
                    }
                }
            }
            else
            {
                int i = ClassSupplire.SP_UpdateSupllire(FormManagementSupplire.Su_ID, txtnamesuppl.Text, txtmobile.Text);
                if (i == 1)
                {
                    MessageBox.Show("تم تعديل بيانات  المورد بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmobile.Text = txtnamesuppl.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtmobile.Text = txtnamesuppl.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}