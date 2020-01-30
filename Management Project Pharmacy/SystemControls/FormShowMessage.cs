using System;
using System.Data;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.SystemControls
{
    public partial class FormShowMessage : Form
    {
        public FormShowMessage()
        {
            InitializeComponent();
            FormShowMessage_Load(null,null);
        }

        private void FormShowMessage_Load(object sender, EventArgs e)
        {
        dgv.DataSource=  ClassMassege.SP_ShowMessageByName(Program.UserFull.ToString());
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string  r= "Massege Read";
            ClassMassege.SP_UpdateMessageByName(Program.UserFull.ToString(),r);
            txtmsgtitla.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            txtmsgdetails.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            FormShowMessage_Load(null, null);
        }
    }
}
