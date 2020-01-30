using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.Shared;

using Management_Project_Pharmacy.BL;
namespace Management_Project_Pharmacy.PL
{
    public partial class FormManagementProduct : Form
    {
        public FormManagementProduct()
        {
            InitializeComponent();
            ptnselectall_Click(null, null);
        }

        private void ptnselectall_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassProduct.SP_SelectAllProduct();
            dgv.Rows.Clear();
            // لكل Row
            // فى الصفوف 
            foreach (DataRow dr in dt.Rows)
            {
                dgv.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
            }


        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ClassProduct.SP_SearchProduct(txtsearch.Text);
            dgv.Rows.Clear();
            // لكل Row
            // فى الصفوف 
            foreach (DataRow dr in dt.Rows)
            {
                dgv.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
            }
        }
        private void ptnshowpic_Click(object sender, EventArgs e)
        {
            string ErrorMsg;
            try
            {
                byte[] arr = ClassProduct.SP_GetImageProduct(int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString()));
                MemoryStream ms = new MemoryStream(arr);
                FormImageProduct Frm = new FormImageProduct();
                Frm.PicProduct.Image = Image.FromStream(ms);
                Frm.ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorMsg = ex.Message;
            }
        }

        private void ptnExpireDate_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassProduct.SP_GetExpiredDateProduct(int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString()));
            if (dt.Rows.Count > 0)
            {
                FormExpirdDateProduct frm = new FormExpirdDateProduct();
                frm.dgv.DataSource = dt;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("عفواً لا يوجد صلاحيات لهذا المنتج", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static int ID;
        private void ptndelete_Click(object sender, EventArgs e)
        {
             ID = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult DR = MessageBox.Show("هل أنت متأكد من حذف  المنتج المحدد", "النظام تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (DR == DialogResult.Yes)
            {
                int i = ClassProduct.SP_DeleteProduct(ID);
                if (i == 1)
                {
                    MessageBox.Show("تم حذف المنتج بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                ptnselectall_Click(null, null);
            }
        }
        private void ptnaddnew_Click(object sender, EventArgs e)
        {
            new FormAddNewProduct(false).ShowDialog();
            ptnselectall_Click(null, null);
        }
        private void ptnupdate_Click(object sender, EventArgs e)
        {
            new FormAddNewProduct(true).ShowDialog();
            ///
            //  Error ID
            ///
            ID = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
            ptnselectall_Click(null, null);
        }
       

        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptnpirent_Click(object sender, EventArgs e)
        {
            RPT.FormReports frmReport = new RPT.FormReports();
            RPT.CrystalReportPrintAllProduct AllProducts = new RPT.CrystalReportPrintAllProduct();
            frmReport.crystalReportViewer1.ReportSource = AllProducts;
            frmReport.ShowDialog();
        }

        private void ptnsave_Click(object sender, EventArgs e)
        {
            RPT.CrystalReportPrintAllProduct Report = new RPT.CrystalReportPrintAllProduct();
            DiskFileDestinationOptions Destination = new DiskFileDestinationOptions();
            Destination.DiskFileName = @"C:\Exportes\ExportReport.xls";
            ExcelFormatOptions ExcelFormat = new ExcelFormatOptions();

            ExportOptions Export = new ExportOptions();
            Export = Report.ExportOptions;
            Export.ExportDestinationType = ExportDestinationType.DiskFile;
            Export.ExportFormatType = ExportFormatType.Excel;
            Export.ExportDestinationOptions = Destination;
            Export.ExportFormatOptions = ExcelFormat;
            Report.Export();
            MessageBox.Show("Data Export Success!!");
        }

        private void ptnprintone_Click(object sender, EventArgs e)
        {
            RPT.FormReports frmReport = new RPT.FormReports();
            RPT.CrystalReportPrintOneProduct OneProducts = new RPT.CrystalReportPrintOneProduct();
            OneProducts.SetParameterValue("@P_ID", dgv.SelectedRows[0].Cells[0].Value);
            frmReport.crystalReportViewer1.ReportSource = OneProducts;
            frmReport.ShowDialog();
        }
    }
}