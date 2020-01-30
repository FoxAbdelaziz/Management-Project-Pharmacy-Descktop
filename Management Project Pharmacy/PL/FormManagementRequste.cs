using System;
using System.Data;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementRequste : Form
    {
        public FormManagementRequste()
        {
            InitializeComponent();
            ptnDispaly_Click(null,null);
        }

        private void ptnDispaly_Click(object sender, EventArgs e)
        {
            dgv.DataSource = ClassRequst.SP_SelectAllRequest();        
        }

        private void ptnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptnPrint_Click(object sender, EventArgs e)
        {
            RPT.FormReports frmReport = new RPT.FormReports();
            RPT.CrystalReportPrintRequest PrintRequest = new RPT.CrystalReportPrintRequest();
            PrintRequest.SetParameterValue("@Request_ID", dgv.SelectedRows[0].Cells[0].Value);
            frmReport.crystalReportViewer1.ReportSource = PrintRequest;
            frmReport.ShowDialog();
        }
    }
}