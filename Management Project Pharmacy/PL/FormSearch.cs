using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormSearch : Form
    {
        public FormSearch(string _Check)
        {
            InitializeComponent();
            if (_Check == "Supller")
            {
                dgv.DataSource= ClassSupplire.SP_SelcetAllSupplier();
                this.Text = "الشاشة الخاصة ببيانات الموردين";
            }
            else if (_Check=="Product")
            {
                dgv.DataSource = ClassProduct.SP_SelectProductDetails();
                this.Text = "الشاشة الخاصة ببيانات الأدوية";
            }

            else if (_Check == "Customer")
            {
                dgv.DataSource = ClassCustomer.SP_SelectCustomer();
                this.Text = " الشاشة الخاصة ببيانات العملاء";
            }

        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}