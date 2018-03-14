using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joesAutomotiveCRM
{
    public partial class invoicesDetails : Form
    {
        List<string> invoiceItems = new List<string>();
        public invoicesDetails()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataSet);

        }

        private void invoicesDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.joesAutomotiveDataSet.Invoices);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            /*The purpose of refresh functions is to check the data in the database 
            and set all textboxes on the form to that.*/
            txtInvoiceLn1.Text = "";
            txtInvoiceLn2.Text = "";
            txtInvoiceLn3.Text = "";
            txtInvoiceLn4.Text = "";
            txtTax.Text = "";
            txtInvoiceNo.Text = "";
            txtPONo.Text = "";
            txtTerms.Text = "";
            txtDueDate.Text = "";
            txtAppType.Text = "";

            listBoxInvoiceItems.SelectedIndex = 0;
            txtDesc.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*The save function sets the items in the database
            to what is currently on the form.*/

        }

        private void checkBoxFluidCheckup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFluidCheckup.Checked)
            {
                labelFluidCUPrice.Text = "$24.99";
                labelFluidCUVAT.Text = (double.Parse(labelFluidCUPrice.Text) * 0.06).ToString("c");
                labelFluidCUTotal.Text = (double.Parse(labelFluidCUPrice.Text) * 1.06).ToString("c");
            }
            else
            {

            }
        }
    }
}
