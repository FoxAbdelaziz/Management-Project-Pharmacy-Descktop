using System;
using System.Data;
using System.Windows.Forms;
using Management_Project_Pharmacy.BL;
using System.IO;
using System.Drawing;

namespace Management_Project_Pharmacy.PL
{
    public partial class FormAddNewProduct : Form
    {
        bool _Update;
        public FormAddNewProduct(bool Update)
        {
            InitializeComponent();
            this._Update = Update;
            // -----Fill Data Category in Combo Box ------ 
            DataTable dtCat = ClassProduct.SP_FillCategoryComboBox();
            CmbCat.DataSource = dtCat;
            CmbCat.DisplayMember = "Cat_Name";
            CmbCat.ValueMember = "Cat_ID";


            // -----Fill Data AcviteMatrile in Combo Box ------ 
            DataTable dtAm = ClassProduct.SP_FillAcviteMatrileComboBox();
            CmbAm.DataSource = dtAm;
            CmbAm.DisplayMember = "Am_Name";
            CmbAm.ValueMember = "Am_ID";


            // -----Fill Data SecintificName in Combo Box ------ 
            DataTable dtSn = ClassProduct.SP_FillSecintificNameComboBox();
            CmbSn.DataSource = dtSn;
            CmbSn.DisplayMember = "Sn_Name";
            CmbSn.ValueMember = "Sn_ID";

            CmbAm.SelectedIndex = CmbCat.SelectedIndex = CmbSn.SelectedIndex = -1;


            if (_Update == true)
            {
                this.Text = "الشاشة الخاصة بتعديل بيانات المنتج";
                Ptnadd.Text = "تعديل";
                DataTable dt = ClassProduct.SP_GetSelectedProduct(FormManagementProduct.ID);
                foreach (DataRow dr in dt.Rows)
                {
                    CmbCat.Text = dr["Cat_Name"].ToString();
                    txtproductname.Text = dr["P_Name"].ToString();
                    txtProductDesc.Text = dr["P_Description"].ToString();
                    txtsellprice.Text = dr["SellPrice"].ToString();
                    txtbuyprice.Text = dr["BuyPrice"].ToString();
                    CmbAm.Text = dr["Am_Name"].ToString();
                    CmbSn.Text = dr["Sn_Name"].ToString();
                    txtbarcode.Text = dr["Barcode"].ToString();
                    try
                    {
                        if (!Convert.IsDBNull(dr["P_Image"]))
                        {
                            byte[] arr = (byte[])dr["P_Image"];
                            MemoryStream ms = new MemoryStream(arr);
                            Pic.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                this.Text = "الشاشة الخاصة بأضافة بيانات المنتج";
                Ptnadd.Text = "أضافة";
            }
        }

        private void PtnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "All Files|*.*|jpg|*.jpg|Png|*.png";
                ofd.ShowDialog();
                Pic.Image = Image.FromFile(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PTNADD_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            Pic.Image.Save(ms, Pic.Image.RawFormat);
            byte[] arr = ms.ToArray();

            if (txtproductname.Text == string.Empty)
            {
                MessageBox.Show("يجب أدخال أسم المنتج المراد اضاقته", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtbuyprice.Text == string.Empty)
            {
                MessageBox.Show("يجب أختيار سعر الشراء", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsellprice.Text == string.Empty)
            {
                MessageBox.Show("يجب أختيار السعر للجمهور", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (_Update == false)
                {
                    int i = ClassProduct.SP_InsertProduct(txtproductname.Text, txtProductDesc.Text, arr, txtbuyprice.Text, txtsellprice.Text, (int)CmbCat.SelectedValue, (int)CmbAm.SelectedValue, (int)CmbSn.SelectedValue, txtbarcode.Text);
                    if (i == 1)
                    {
                        MessageBox.Show("تم أضاقة بيانات المنتج بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /// Error 
                        //foreach (TextBox item in groupBox1.Controls)
                        //{
                        //    item.Text = string.Empty;
                        //}
                        foreach (Control item in groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = string.Empty;
                            }
                        }
                        //txtproductname.Text = txtProductDesc.Text = txtbuyprice.Text = txtsellprice.Text = txtbarcode.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        foreach (Control item in groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = string.Empty;
                            }
                        }
                        //txtproductname.Text = txtProductDesc.Text = txtbuyprice.Text = txtsellprice.Text = txtbarcode.Text = string.Empty;
                    }
                }
                else
                {
                    int i = ClassProduct.SP_UpdateProduct(FormManagementProduct.ID, txtproductname.Text, txtProductDesc.Text, arr, txtbuyprice.Text, txtsellprice.Text, (int)CmbCat.SelectedValue, (int)CmbAm.SelectedValue, (int)CmbSn.SelectedValue, txtbarcode.Text);
                    if (i == 1)
                    {
                        MessageBox.Show("تم تعديل بيانات المنتج بنجاح", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /// Error 
                        //foreach (TextBox item in groupBox1.Controls)
                        //{
                        //    item.Text = string.Empty;
                        //}
                        foreach (Control item in groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("", "النظام", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        foreach (Control item in groupBox1.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = string.Empty;
                            }
                        }
                        //txtproductname.Text = txtProductDesc.Text = txtbuyprice.Text = txtsellprice.Text = txtbarcode.Text = string.Empty;
                    }
                }
            }
        }
        private void PtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}