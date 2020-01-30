using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
using System.IO;
using System.Drawing;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewCustomer : Form
    {
        bool Isupdate;
        public FormAddNewCustomer(bool _IsUpdate)
        {

            InitializeComponent();
            this.Isupdate = _IsUpdate;
            com_cus_contry.DataSource = ClassCountry.SP_SelectAllCountry();
            com_cus_contry.DisplayMember = "أسم الدولة";
            com_cus_contry.ValueMember = "معرف الدولة";

            com_cus_contry_SelectionChangeCommitted(null, null);

            if (Isupdate == true)
            {
                this.Text = "تعديل بيانات العميل";
                PTN.Text = "تعديل";
                txt_cus_name.Text = FormManagementCustomer.Row.Cells[1].Value.ToString();
                txt_cus_address.Text = FormManagementCustomer.Row.Cells[2].Value.ToString();
                txt_cus_mobile.Text = FormManagementCustomer.Row.Cells[3].Value.ToString();

                MemoryStream MS = new MemoryStream(FormManagementCustomer.Row.Cells[4].Value as byte[]);
                pic_cus.Image = Image.FromStream(MS);

                com_cus_contry.Text = FormManagementCustomer.Row.Cells[5].Value.ToString();
                com_cus_city.Text = FormManagementCustomer.Row.Cells[6].Value.ToString();

            }
            else
            {
                this.Text = "أضافة بيانات العميل";
                PTN.Text = "أضافة";
            }
        }

        private void ptnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void com_cus_contry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            com_cus_city.DataSource = ClassCustomer.SP_SelectCityByCountry(int.Parse(com_cus_contry.SelectedValue.ToString()));
            com_cus_city.DisplayMember = "City_Name";
            com_cus_city.ValueMember = "City_ID";
        }

        private void pic_cus_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic_cus.Image = Image.FromFile(ofd.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "النظام", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void PTN_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pic_cus.Image.Save(ms, pic_cus.Image.RawFormat);
            byte[] cuimage = ms.ToArray();

            if (Isupdate == true)
            {
                int iu = ClassCustomer.SP_UpdateCustomer(int.Parse(FormManagementCustomer.Row.Cells[0].Value.ToString()), txt_cus_name.Text, txt_cus_address.Text, txt_cus_mobile.Text, cuimage, int.Parse(com_cus_city.SelectedValue.ToString()));
                if (iu == 1)
                {
                    MessageBox.Show("تم تعديل البيانات بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cus_address.Text = txt_cus_mobile.Text = txt_cus_name.Text = "";
                }
                else
                {
                    MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_cus_address.Text = txt_cus_mobile.Text = txt_cus_name.Text = "";
                }
            }
            else
            {
                if (txt_cus_name.Text == "")
                {
                    MessageBox.Show("يجب أدخال أسم العميل ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txt_cus_mobile.Text == "")
                {
                    MessageBox.Show("يجب أدخال رقم التلفون ", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    int i = ClassCustomer.SP_InsertCustomer(txt_cus_name.Text, txt_cus_address.Text, txt_cus_mobile.Text, cuimage, int.Parse(com_cus_city.SelectedValue.ToString()));
                    if (i == 1)
                    {
                        MessageBox.Show("تم أضافة العميل بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_cus_address.Text = txt_cus_mobile.Text = txt_cus_name.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_cus_address.Text = txt_cus_mobile.Text = txt_cus_name.Text = "";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}