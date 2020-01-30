using System;
using System.Data;
using Management_Project_Pharmacy.BL;
using System.Windows.Forms;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewPurchasse : Form
    {
        public FormAddNewPurchasse()
        {
            InitializeComponent();
            txtBuyerName.Text = Program.UserFull;
        }

        private void ptnaddsupplier_Click(object sender, EventArgs e)
        {
            ;
            FormSearch Frm = new FormSearch("Supller");
            Frm.ShowDialog();

            txtsu_id.Text = Frm.dgv.CurrentRow.Cells[0].Value.ToString();
            txtsu_name.Text = Frm.dgv.CurrentRow.Cells[1].Value.ToString();
            txtsu_phone.Text = Frm.dgv.CurrentRow.Cells[2].Value.ToString();
        }

        private void ptnaddproduct_Click(object sender, EventArgs e)
        {
            FormSearch Frm = new FormSearch("Product");
            Frm.ShowDialog();
            txtproduct_id.Text = Frm.dgv.CurrentRow.Cells[0].Value.ToString();
            txtproduct_name.Text = Frm.dgv.CurrentRow.Cells[1].Value.ToString();
            txtproduct_price.Text = Frm.dgv.CurrentRow.Cells[2].Value.ToString();
        }

        private void ptnnewpurchasse_Click(object sender, EventArgs e)
        {
            txtsu_id.Text = txtsu_name.Text = txtsu_phone.Text = string.Empty;
            ptnaddproduct.Enabled =ptnaddsupplier.Enabled =ptnsave.Enabled = true;
            ptnnewpurchasse.Enabled = false;
        }

        private void txtprod_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;
            }
        }

        private void txtprod_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtproduct_id.Text == "")
                {
                    MessageBox.Show("يجب أحتيار منتج", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtqty.Text == "" || double.Parse(txtqty.Text) <= 0)
                {
                    MessageBox.Show("يجب أدخال كمية المنتج وتكون موجبها", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (txtproduct_id.Text == dgv.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("هذا المنتج موجود بالفعل!!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    string expdata = "";
                    if (txtProductExpiredate.Checked)
                        expdata = txtProductExpiredate.Text;
                    dgv.Rows.Add(txtproduct_id.Text, txtproduct_name.Text, expdata, txtproduct_price.Text, txtqty.Text);
                    txtproduct_id.Text = txtproduct_name.Text = txtProductExpiredate.Text = txtproduct_price.Text = txtqty.Text = "";
                    ptndelete.Enabled = true;
                    CalcTotal();
                }
            }
        }

        private void ptndelete_Click(object sender, EventArgs e)
        {

            dgv.Rows.Remove(dgv.CurrentRow);
            CalcTotal();
        }
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtproduct_id.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            txtproduct_name.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            if (dgv.CurrentRow.Cells[2].Value.ToString() == "")
                txtProductExpiredate.Checked = false;
            else
                txtProductExpiredate.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtproduct_price.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            txtqty.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            ptndelete_Click(null, null);
        }

        void CalcTotal()
        {
            double Total = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                Total += double.Parse(dgv.Rows[i].Cells[3].Value.ToString()) * double.Parse(dgv.Rows[i].Cells[4].Value.ToString());
            }
            TxtReqTotal.Text = Total.ToString();
        }

        private void ptnsave_Click(object sender, EventArgs e)
        {
            ;
            if (txtsu_id.Text == "")
            {
                MessageBox.Show("يجب أحتيار المورد", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DataTable TypeRequstDetails = new DataTable();
                    TypeRequstDetails.Columns.Add("P_ID");
                    TypeRequstDetails.Columns.Add("Qty");
                    TypeRequstDetails.Columns.Add("P_Price");
                    foreach (DataGridViewRow dr in dgv.Rows)
                    {
                        TypeRequstDetails.Rows.Add(dr.Cells[0].Value, dr.Cells[4].Value, dr.Cells[3].Value);
                    }
                    DataTable TypeExpiredDate = new DataTable();
                    TypeExpiredDate.Columns.Add("Ex_Date");
                    TypeExpiredDate.Columns.Add("P_ID");
                    TypeExpiredDate.Columns.Add("Qty");
                    foreach (DataGridViewRow dg in dgv.Rows)
                    {
                        object ExpiredDate;
                        if (dg.Cells[2].Value.ToString() == "")
                            ExpiredDate = null;
                        else
                            ExpiredDate = DateTime.Parse(dg.Cells[2].Value.ToString());
                        TypeExpiredDate.Rows.Add(ExpiredDate, dg.Cells[0].Value, dg.Cells[4].Value);

                    }
                    ;
                    int i = ClassRequst.SP_InsertRequst(txtReqdate.Value, TxtReqTotal.Text, int.Parse(txtsu_id.Text), txtBuyerName.Text, TypeRequstDetails, TypeExpiredDate);
                    //if (i == 3)
                    //{
                        MessageBox.Show("تم حفظ بيانات الفاتورة بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv.Rows.Clear();
                        CalcTotal();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    dgv.Rows.Clear();
                    //    CalcTotal();
                    //}
                    ptnprint.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ptnprint.Enabled = ptnnewpurchasse.Enabled = true;
                ptnsave.Enabled = false;
            }
        }


        private void ptnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptnprint_Click(object sender, EventArgs e)
        {
            RPT.FormReports frmReport = new RPT.FormReports();
            RPT.CrystalReportPrintRequest PrintRequest = new RPT.CrystalReportPrintRequest();
            PrintRequest.SetParameterValue("@Request_ID", ClassRequst.Max_ReqID());
            frmReport.crystalReportViewer1.ReportSource = PrintRequest;
            frmReport.ShowDialog();
        }
    }
}