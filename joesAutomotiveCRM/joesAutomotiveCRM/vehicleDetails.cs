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
    public partial class vehicleDetails : Form
    {
        public vehicleDetails(int vehicleID, bool showButton)
        {
            InitializeComponent();
            this.Text = "";
            vehicleButton.Visible = showButton;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            int ownerID = 0;
            customersDetails customersD = new customersDetails(ownerID, false);
        }

        private void refreshInfo()
        {
            /*The purpose of refresh functions is to check the data in the database 
            and set all textboxes on the form to that.*/
            this.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
            txtColor.Text = "";
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshInfo();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            /*The save function sets the items in the database
            to what is currently on the form.*/
        }
    }
}
