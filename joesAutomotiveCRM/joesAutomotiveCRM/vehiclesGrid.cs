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
    public partial class vehiclesGrid : Form
    {
        public vehiclesGrid()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataSet);

        }

        private void vehiclesGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.joesAutomotiveDataSet.Vehicle);

        }
    }
}
