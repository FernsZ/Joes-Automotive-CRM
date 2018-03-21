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
    public partial class customersDetails : Form
    {
        int CustomerID;
        public customersDetails(int customerID, bool showButton)
        {
            CustomerID = customerID;
            InitializeComponent();
            refreshInfo();
            vehicleButton.Visible = showButton;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vehicleID = 0;
            vehicleDetails vehicleD = new vehicleDetails(vehicleID, false);
        }

        private void refreshInfo()
        {
            /*The purpose of refresh functions is to check the data in the database 
            and set all textboxes on the form to that.*/
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /*The save function sets the items in the database
            to what is currently on the form.*/
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void customersDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.joesAutomotiveDataSet.Customers);

        }

        private void buttonNewVehicle_Click(object sender, EventArgs e)
        {
            int vehicleID = 0;
            vehicleDetails vehicleD = new vehicleDetails(vehicleID, false);
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataSet);

        }
    }
}
