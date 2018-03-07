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
        public vehicleDetails(string vehicle, bool showButton)
        {
            InitializeComponent();
            this.Text = vehicle;
            vehicleButton.Visible = showButton;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            string owner = "";
            customersDetails customersD = new customersDetails(owner, false);
        }
    }
}
