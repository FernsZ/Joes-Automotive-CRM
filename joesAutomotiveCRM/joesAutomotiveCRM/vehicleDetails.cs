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
        enum Make { Audi, Cadillac, Chevrolet, Chrysler, Ferrari, Ford, GM, Lexus, MercedesBenz, Porsche, Tesla, Toyota, Volkswagen, Other, Error }
        Make make;
        int VehicleID;
        public vehicleDetails(int vehicleID, bool showButton)
        {
            VehicleID = vehicleID;
            InitializeComponent();
            refreshInfo();
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
            this.Text = this.vehicleTableAdapter.getModel(VehicleID);
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

        private Make makeParse(string makeS)
        {
            switch (makeS)
            {
                case "Audi":
                    make = Make.Audi;
                    break;
                case "Cadillac":
                    make = Make.Cadillac;
                    break;
                case "Chevrolet":
                    make = Make.Chevrolet;
                    break;
                case "Chrysler":
                    make = Make.Chrysler;
                    break;
                case "Ferrari":
                    make = Make.Ferrari;
                    break;
                case "Ford":
                    make = Make.Ford;
                    break;
                case "GM":
                    make = Make.GM;
                    break;
                case "Lexus":
                    make = Make.Lexus;
                    break;
                case "Mercedes-Benz":
                    make = Make.MercedesBenz;
                    break;
                case "Porsche":
                    make = Make.Porsche;
                    break;
                case "Tesla":
                    make = Make.Tesla;
                    break;
                case "Toyota":
                    make = Make.Toyota;
                    break;
                case "Volkswagen":
                    make = Make.Volkswagen;
                    break;
                case "Other":
                    make = Make.Other;
                    break;
                default:
                    make = Make.Error;
                    MessageBox.Show("Error. Please enter a valid Make./nEnter Other and contact programmer to fix later if Make should be valid.");
                    break;
            }
            return make;
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataSet);

        }

        private void vehicleDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.joesAutomotiveDataSet.Vehicle);

        }
    }
}
