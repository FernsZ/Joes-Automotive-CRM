namespace joesAutomotiveCRM
{
    partial class invoicesDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoicesDetails));
            this.joesAutomotiveDataSet = new joesAutomotiveCRM.joesAutomotiveDataSet();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.TableAdapterManager();
            this.backButton = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.labelTaxDate = new System.Windows.Forms.Label();
            this.labelInvoiceNo = new System.Windows.Forms.Label();
            this.labelPONo = new System.Windows.Forms.Label();
            this.txtTerms = new System.Windows.Forms.TextBox();
            this.txtPONo = new System.Windows.Forms.TextBox();
            this.labelTerms = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.txtAppType = new System.Windows.Forms.TextBox();
            this.labelAppType = new System.Windows.Forms.Label();
            this.txtInvoiceLn1 = new System.Windows.Forms.TextBox();
            this.labelInvoiceTo = new System.Windows.Forms.Label();
            this.labelCaseworker = new System.Windows.Forms.Label();
            this.txtCaseworker = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtTotalPerItem = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelTotalPerItem = new System.Windows.Forms.Label();
            this.txtVatTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.listBoxInvoiceItems = new System.Windows.Forms.ListBox();
            this.labelVatTotal = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.checkBoxFluidCheckup = new System.Windows.Forms.CheckBox();
            this.labelFluidCUPrice = new System.Windows.Forms.Label();
            this.labelFluidCUVAT = new System.Windows.Forms.Label();
            this.labelFluidCUTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // joesAutomotiveDataSet
            // 
            this.joesAutomotiveDataSet.DataSetName = "joesAutomotiveDataSet";
            this.joesAutomotiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.joesAutomotiveDataSet;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = this.invoicesTableAdapter;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(386, 294);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(290, 294);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(90, 23);
            this.buttonExport.TabIndex = 4;
            this.buttonExport.Text = "Export as .txt";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(402, 29);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(60, 20);
            this.txtInvoiceNo.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(336, 29);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(60, 20);
            this.txtTax.TabIndex = 6;
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(401, 71);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(60, 20);
            this.txtDueDate.TabIndex = 8;
            // 
            // labelTaxDate
            // 
            this.labelTaxDate.AutoSize = true;
            this.labelTaxDate.Location = new System.Drawing.Point(343, 13);
            this.labelTaxDate.Name = "labelTaxDate";
            this.labelTaxDate.Size = new System.Drawing.Size(51, 13);
            this.labelTaxDate.TabIndex = 10;
            this.labelTaxDate.Text = "Tax Date";
            // 
            // labelInvoiceNo
            // 
            this.labelInvoiceNo.AutoSize = true;
            this.labelInvoiceNo.Location = new System.Drawing.Point(404, 13);
            this.labelInvoiceNo.Name = "labelInvoiceNo";
            this.labelInvoiceNo.Size = new System.Drawing.Size(62, 13);
            this.labelInvoiceNo.TabIndex = 11;
            this.labelInvoiceNo.Text = "Invoice No.";
            // 
            // labelPONo
            // 
            this.labelPONo.AutoSize = true;
            this.labelPONo.Location = new System.Drawing.Point(276, 55);
            this.labelPONo.Name = "labelPONo";
            this.labelPONo.Size = new System.Drawing.Size(48, 13);
            this.labelPONo.TabIndex = 12;
            this.labelPONo.Text = "P.O. No.";
            // 
            // txtTerms
            // 
            this.txtTerms.Location = new System.Drawing.Point(335, 71);
            this.txtTerms.Name = "txtTerms";
            this.txtTerms.Size = new System.Drawing.Size(60, 20);
            this.txtTerms.TabIndex = 13;
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(269, 71);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(60, 20);
            this.txtPONo.TabIndex = 14;
            // 
            // labelTerms
            // 
            this.labelTerms.AutoSize = true;
            this.labelTerms.Location = new System.Drawing.Point(345, 55);
            this.labelTerms.Name = "labelTerms";
            this.labelTerms.Size = new System.Drawing.Size(36, 13);
            this.labelTerms.TabIndex = 15;
            this.labelTerms.Text = "Terms";
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Location = new System.Drawing.Point(404, 55);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(53, 13);
            this.labelDueDate.TabIndex = 16;
            this.labelDueDate.Text = "Due Date";
            // 
            // txtAppType
            // 
            this.txtAppType.Location = new System.Drawing.Point(267, 119);
            this.txtAppType.Name = "txtAppType";
            this.txtAppType.Size = new System.Drawing.Size(192, 20);
            this.txtAppType.TabIndex = 17;
            // 
            // labelAppType
            // 
            this.labelAppType.AutoSize = true;
            this.labelAppType.Location = new System.Drawing.Point(320, 103);
            this.labelAppType.Name = "labelAppType";
            this.labelAppType.Size = new System.Drawing.Size(86, 13);
            this.labelAppType.TabIndex = 18;
            this.labelAppType.Text = "Application Type";
            // 
            // txtInvoiceLn1
            // 
            this.txtInvoiceLn1.Location = new System.Drawing.Point(7, 48);
            this.txtInvoiceLn1.Name = "txtInvoiceLn1";
            this.txtInvoiceLn1.Size = new System.Drawing.Size(247, 20);
            this.txtInvoiceLn1.TabIndex = 19;
            // 
            // labelInvoiceTo
            // 
            this.labelInvoiceTo.AutoSize = true;
            this.labelInvoiceTo.Location = new System.Drawing.Point(6, 32);
            this.labelInvoiceTo.Name = "labelInvoiceTo";
            this.labelInvoiceTo.Size = new System.Drawing.Size(58, 13);
            this.labelInvoiceTo.TabIndex = 23;
            this.labelInvoiceTo.Text = "Invoice To";
            // 
            // labelCaseworker
            // 
            this.labelCaseworker.AutoSize = true;
            this.labelCaseworker.Location = new System.Drawing.Point(4, 87);
            this.labelCaseworker.Name = "labelCaseworker";
            this.labelCaseworker.Size = new System.Drawing.Size(88, 13);
            this.labelCaseworker.TabIndex = 24;
            this.labelCaseworker.Text = "Your Caseworker";
            // 
            // txtCaseworker
            // 
            this.txtCaseworker.Location = new System.Drawing.Point(7, 103);
            this.txtCaseworker.Name = "txtCaseworker";
            this.txtCaseworker.Size = new System.Drawing.Size(247, 20);
            this.txtCaseworker.TabIndex = 25;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(7, 152);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(247, 20);
            this.txtDesc.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(266, 168);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(60, 20);
            this.txtPrice.TabIndex = 29;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(332, 168);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(60, 20);
            this.txtVat.TabIndex = 28;
            // 
            // txtTotalPerItem
            // 
            this.txtTotalPerItem.Location = new System.Drawing.Point(398, 168);
            this.txtTotalPerItem.Name = "txtTotalPerItem";
            this.txtTotalPerItem.ReadOnly = true;
            this.txtTotalPerItem.Size = new System.Drawing.Size(60, 20);
            this.txtTotalPerItem.TabIndex = 27;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(4, 136);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(60, 13);
            this.labelDesc.TabIndex = 30;
            this.labelDesc.Text = "Description";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(280, 152);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 31;
            this.labelPrice.Text = "Price";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(346, 152);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(28, 13);
            this.labelVat.TabIndex = 32;
            this.labelVat.Text = "VAT";
            // 
            // labelTotalPerItem
            // 
            this.labelTotalPerItem.AutoSize = true;
            this.labelTotalPerItem.Location = new System.Drawing.Point(408, 151);
            this.labelTotalPerItem.Name = "labelTotalPerItem";
            this.labelTotalPerItem.Size = new System.Drawing.Size(31, 13);
            this.labelTotalPerItem.TabIndex = 33;
            this.labelTotalPerItem.Text = "Total";
            // 
            // txtVatTotal
            // 
            this.txtVatTotal.Location = new System.Drawing.Point(397, 219);
            this.txtVatTotal.Name = "txtVatTotal";
            this.txtVatTotal.ReadOnly = true;
            this.txtVatTotal.Size = new System.Drawing.Size(60, 20);
            this.txtVatTotal.TabIndex = 34;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(397, 243);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(60, 20);
            this.txtSubtotal.TabIndex = 35;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(397, 268);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(60, 20);
            this.txtTotal.TabIndex = 36;
            // 
            // listBoxInvoiceItems
            // 
            this.listBoxInvoiceItems.FormattingEnabled = true;
            this.listBoxInvoiceItems.Location = new System.Drawing.Point(7, 219);
            this.listBoxInvoiceItems.Name = "listBoxInvoiceItems";
            this.listBoxInvoiceItems.Size = new System.Drawing.Size(247, 69);
            this.listBoxInvoiceItems.TabIndex = 37;
            // 
            // labelVatTotal
            // 
            this.labelVatTotal.AutoSize = true;
            this.labelVatTotal.Location = new System.Drawing.Point(336, 222);
            this.labelVatTotal.Name = "labelVatTotal";
            this.labelVatTotal.Size = new System.Drawing.Size(55, 13);
            this.labelVatTotal.TabIndex = 38;
            this.labelVatTotal.Text = "VAT Total";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(345, 246);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(46, 13);
            this.labelSubtotal.TabIndex = 39;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(344, 271);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(47, 13);
            this.labelTotal.TabIndex = 40;
            this.labelTotal.Text = "TOTAL";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(7, 294);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 41;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(89, 294);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(171, 294);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 43;
            this.buttonLoad.Text = "Load .txt";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // checkBoxFluidCheckup
            // 
            this.checkBoxFluidCheckup.AutoSize = true;
            this.checkBoxFluidCheckup.Location = new System.Drawing.Point(7, 195);
            this.checkBoxFluidCheckup.Name = "checkBoxFluidCheckup";
            this.checkBoxFluidCheckup.Size = new System.Drawing.Size(93, 17);
            this.checkBoxFluidCheckup.TabIndex = 44;
            this.checkBoxFluidCheckup.Text = "Fluid checkup";
            this.checkBoxFluidCheckup.UseVisualStyleBackColor = true;
            this.checkBoxFluidCheckup.CheckedChanged += new System.EventHandler(this.checkBoxFluidCheckup_CheckedChanged);
            // 
            // labelFluidCUPrice
            // 
            this.labelFluidCUPrice.AutoSize = true;
            this.labelFluidCUPrice.Location = new System.Drawing.Point(277, 195);
            this.labelFluidCUPrice.Name = "labelFluidCUPrice";
            this.labelFluidCUPrice.Size = new System.Drawing.Size(40, 13);
            this.labelFluidCUPrice.TabIndex = 45;
            this.labelFluidCUPrice.Text = "$24.99";
            // 
            // labelFluidCUVAT
            // 
            this.labelFluidCUVAT.AutoSize = true;
            this.labelFluidCUVAT.Location = new System.Drawing.Point(332, 195);
            this.labelFluidCUVAT.Name = "labelFluidCUVAT";
            this.labelFluidCUVAT.Size = new System.Drawing.Size(0, 13);
            this.labelFluidCUVAT.TabIndex = 46;
            // 
            // labelFluidCUTotal
            // 
            this.labelFluidCUTotal.AutoSize = true;
            this.labelFluidCUTotal.Location = new System.Drawing.Point(397, 195);
            this.labelFluidCUTotal.Name = "labelFluidCUTotal";
            this.labelFluidCUTotal.Size = new System.Drawing.Size(0, 13);
            this.labelFluidCUTotal.TabIndex = 47;
            // 
            // invoicesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 322);
            this.Controls.Add(this.labelFluidCUTotal);
            this.Controls.Add(this.labelFluidCUVAT);
            this.Controls.Add(this.labelFluidCUPrice);
            this.Controls.Add(this.checkBoxFluidCheckup);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelVatTotal);
            this.Controls.Add(this.listBoxInvoiceItems);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtVatTotal);
            this.Controls.Add(this.labelTotalPerItem);
            this.Controls.Add(this.labelVat);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtTotalPerItem);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCaseworker);
            this.Controls.Add(this.labelCaseworker);
            this.Controls.Add(this.labelInvoiceTo);
            this.Controls.Add(this.txtInvoiceLn1);
            this.Controls.Add(this.labelAppType);
            this.Controls.Add(this.txtAppType);
            this.Controls.Add(this.labelDueDate);
            this.Controls.Add(this.labelTerms);
            this.Controls.Add(this.txtPONo);
            this.Controls.Add(this.txtTerms);
            this.Controls.Add(this.labelPONo);
            this.Controls.Add(this.labelInvoiceNo);
            this.Controls.Add(this.labelTaxDate);
            this.Controls.Add(this.txtDueDate);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "invoicesDetails";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.invoicesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private joesAutomotiveDataSet joesAutomotiveDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private joesAutomotiveDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private joesAutomotiveDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label labelTaxDate;
        private System.Windows.Forms.Label labelInvoiceNo;
        private System.Windows.Forms.Label labelPONo;
        private System.Windows.Forms.TextBox txtTerms;
        private System.Windows.Forms.TextBox txtPONo;
        private System.Windows.Forms.Label labelTerms;
        private System.Windows.Forms.Label labelDueDate;
        private System.Windows.Forms.TextBox txtAppType;
        private System.Windows.Forms.Label labelAppType;
        private System.Windows.Forms.TextBox txtInvoiceLn1;
        private System.Windows.Forms.Label labelInvoiceTo;
        private System.Windows.Forms.Label labelCaseworker;
        private System.Windows.Forms.TextBox txtCaseworker;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtTotalPerItem;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelTotalPerItem;
        private System.Windows.Forms.TextBox txtVatTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox listBoxInvoiceItems;
        private System.Windows.Forms.Label labelVatTotal;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.CheckBox checkBoxFluidCheckup;
        private System.Windows.Forms.Label labelFluidCUPrice;
        private System.Windows.Forms.Label labelFluidCUVAT;
        private System.Windows.Forms.Label labelFluidCUTotal;
    }
}