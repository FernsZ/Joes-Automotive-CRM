namespace joesAutomotiveCRM
{
    partial class invoicesGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoicesGrid));
            this.joesAutomotiveDataSet = new joesAutomotiveCRM.joesAutomotiveDataSet();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicesTableAdapter = new joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.InvoicesTableAdapter();
            this.tableAdapterManager = new joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.TableAdapterManager();
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
            // invoicesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 385);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "invoicesGrid";
            this.Text = "invoicesGrid";
            this.Load += new System.EventHandler(this.invoicesGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private joesAutomotiveDataSet joesAutomotiveDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private joesAutomotiveDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private joesAutomotiveDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}