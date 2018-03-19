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
    public partial class customersGrid : Form
    {
        public customersGrid()
        {
            InitializeComponent();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            int customerID = 0;
            customersDetails customersD = new customersDetails(customerID, true);
            customersD.ShowDialog();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataSet);

        }

        private void customersGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.joesAutomotiveDataSet.Customers);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
