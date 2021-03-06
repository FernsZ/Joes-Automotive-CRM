﻿using System;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            customersGrid customerG = new customersGrid();
            customerG.ShowDialog();
        }

        private void vehiclesButton_Click(object sender, EventArgs e)
        {
            vehiclesGrid vehicleG = new vehiclesGrid();
            vehicleG.ShowDialog();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            partsGrid parts = new partsGrid();
            parts.ShowDialog();
        }

        private void invoicesButton_Click(object sender, EventArgs e)
        {
            invoicesGrid invoiceG = new invoicesGrid();
            invoiceG.ShowDialog();
        }
    }
}
