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
        public customersDetails(string customer, bool showButton)
        {
            InitializeComponent();
            this.Text = customer;
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
            this.Text = "";
            lblName.Text = "";
            lblPhone.Text = "";
            lblPhone2.Text = "";
            lblAddress.Text = "";
            lblAddressLn2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicleDetails vehicleD = new vehicleDetails(vehiclesListBox.Text, false);
        }
    }
}
