using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewOrder : Form
    {
        public FormAddNewOrder()
        {
            InitializeComponent();
            txtsalername.Text = Program.UserFull;
        }
        float TotalQty;
        private void ptnaddproduct_Click(object sender, EventArgs e)
        {
            FormSearch frm = new FormSearch("Product");
            frm.ShowDialog();
            txtproduct_id.Text = frm.dgv.CurrentRow.Cells[0].Value.ToString();
            txtproduct_name.Text = frm.dgv.CurrentRow.Cells[1].Value.ToString();
            txtproduct_price.Text = frm.dgv.CurrentRow.Cells[2].Value.ToString();
            TotalQty = float.Parse( frm.dgv.CurrentRow.Cells[3].Value.ToString());
        }

        private void ptnaddcoustomer_Click(object sender, EventArgs e)
        {
            FormSearch frm = new FormSearch("Customer");
            frm.ShowDialog();
            txtcu_id.Text = frm.dgv.CurrentRow.Cells[0].Value.ToString();
            txtcu_name.Text = frm.dgv.CurrentRow.Cells[1].Value.ToString();
            txtcu_phone.Text = frm.dgv.CurrentRow.Cells[2].Value.ToString();
        }

        private void ptnneworder_Click(object sender, EventArgs e)
        {
            ptnaddcoustomer.Enabled = ptnaddproduct.Enabled =ptnsave.Enabled= true;
            ptnneworder.Enabled = false;
            txtcu_id.Text = txtcu_name.Text = txtcu_phone.Text = txtproduct_id.Text=txtproduct_name.Text=txtproduct_price.Text=txtprod_qty.Text="";
            dgv.Rows.Clear();
        }

        private void txtprod_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtproduct_id.Text == "")
                {
                    MessageBox.Show("يجب أختيار منتج", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txtprod_qty.Text == "" || float.Parse(txtprod_qty.Text) <= 0)
                {
                    MessageBox.Show("يجب أدخال كمية المنتج وتكون موجبها", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (float.Parse(txtprod_qty.Text)>TotalQty)
                {
                    MessageBox.Show("الكمية المطلوبة أكبر من الكمية الموجودة فى المخزن!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (txtproduct_id.Text == dgv.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("هذا المنتج موجود بالفعل!", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                dgv.Rows.Add(txtproduct_id.Text, txtproduct_name.Text, txtproduct_price.Text, txtprod_qty.Text);
                ptndelete.Enabled = true;
                txtprod_qty.Text = txtproduct_price.Text = txtproduct_name.Text = txtproduct_id.Text = "";
                CalcTotal();
            }
        }

        void CalcTotal()
        {
            float Total = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                Total += float.Parse(dgv.Rows[i].Cells[2].Value.ToString()) * float.Parse(dgv.Rows[i].Cells[3].Value.ToString());
            }
            txtOrderTotal.Text = Total.ToString();
        }


        private void txtprod_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != d)
            {
                e.Handled = true;
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
            txtproduct_price.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            txtprod_qty.Text = dgv.CurrentRow.Cells[3].Value.ToString();

            ptndelete_Click(null, null);
        }

        private void ptnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable TypeOrderDetails = new DataTable();
                TypeOrderDetails.Columns.Add("P_ID");
                TypeOrderDetails.Columns.Add("Qty");
                TypeOrderDetails.Columns.Add("P_Price");
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    TypeOrderDetails.Rows.Add(dgv.Rows[i].Cells[0].Value,dgv.Rows[i].Cells[3].Value,dgv.Rows[i].Cells[2].Value);
                }
                ClassOrder.SP_InsertOrder(txtReqdate.Value,txtOrderTotal.Text,int.Parse(txtcu_id.Text),txtsalername.Text,TypeOrderDetails);
                MessageBox.Show("تم حفظ بيانات الفاتورة بنجاح","النظام",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ptnprint.Enabled =ptnneworder.Enabled= true;
            ptnsave.Enabled = false;
        }


       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}