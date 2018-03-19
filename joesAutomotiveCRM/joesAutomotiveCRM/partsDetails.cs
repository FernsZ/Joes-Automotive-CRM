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
    public partial class partsDetails : Form
    {
        public partsDetails()
        {
            InitializeComponent();
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesAutomotiveDataSet);

        }

        private void partsDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesAutomotiveDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.joesAutomotiveDataSet.Parts);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
