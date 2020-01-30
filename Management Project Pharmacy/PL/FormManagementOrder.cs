using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.PL;
namespace Management_Project_Pharmacy.BL
{
    public partial class FormManagementOrder : Form
    {
        public FormManagementOrder()
        {
            InitializeComponent();
            ptnDispaly_Click(null, null);
        }

        private void ptnDispaly_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClassOrder.SP_SelectAllOrders();
        }

        private void ptnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}