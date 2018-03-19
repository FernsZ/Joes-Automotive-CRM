namespace joesAutomotiveCRM
{
    partial class partsDetails
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
            System.Windows.Forms.Label part_IDLabel;
            System.Windows.Forms.Label part_nameLabel;
            System.Windows.Forms.Label part_costLabel;
            System.Windows.Forms.Label parts_in_stockLabel;
            System.Windows.Forms.Label parts_orderedLabel;
            System.Windows.Forms.Label can_be_applied_toLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(partsDetails));
            this.joesAutomotiveDataSet = new joesAutomotiveCRM.joesAutomotiveDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.PartsTableAdapter();
            this.tableAdapterManager = new joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.TableAdapterManager();
            this.partsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.partsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.part_IDTextBox = new System.Windows.Forms.TextBox();
            this.part_nameTextBox = new System.Windows.Forms.TextBox();
            this.part_costTextBox = new System.Windows.Forms.TextBox();
            this.parts_in_stockTextBox = new System.Windows.Forms.TextBox();
            this.parts_orderedTextBox = new System.Windows.Forms.TextBox();
            this.can_be_applied_toTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            part_IDLabel = new System.Windows.Forms.Label();
            part_nameLabel = new System.Windows.Forms.Label();
            part_costLabel = new System.Windows.Forms.Label();
            parts_in_stockLabel = new System.Windows.Forms.Label();
            parts_orderedLabel = new System.Windows.Forms.Label();
            can_be_applied_toLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).BeginInit();
            this.partsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // part_IDLabel
            // 
            part_IDLabel.AutoSize = true;
            part_IDLabel.Location = new System.Drawing.Point(49, 33);
            part_IDLabel.Name = "part_IDLabel";
            part_IDLabel.Size = new System.Drawing.Size(43, 13);
            part_IDLabel.TabIndex = 1;
            part_IDLabel.Text = "Part ID:";
            // 
            // part_nameLabel
            // 
            part_nameLabel.AutoSize = true;
            part_nameLabel.Location = new System.Drawing.Point(49, 59);
            part_nameLabel.Name = "part_nameLabel";
            part_nameLabel.Size = new System.Drawing.Size(58, 13);
            part_nameLabel.TabIndex = 3;
            part_nameLabel.Text = "Part name:";
            // 
            // part_costLabel
            // 
            part_costLabel.AutoSize = true;
            part_costLabel.Location = new System.Drawing.Point(49, 85);
            part_costLabel.Name = "part_costLabel";
            part_costLabel.Size = new System.Drawing.Size(52, 13);
            part_costLabel.TabIndex = 5;
            part_costLabel.Text = "Part cost:";
            // 
            // parts_in_stockLabel
            // 
            parts_in_stockLabel.AutoSize = true;
            parts_in_stockLabel.Location = new System.Drawing.Point(49, 111);
            parts_in_stockLabel.Name = "parts_in_stockLabel";
            parts_in_stockLabel.Size = new System.Drawing.Size(74, 13);
            parts_in_stockLabel.TabIndex = 7;
            parts_in_stockLabel.Text = "Parts in stock:";
            // 
            // parts_orderedLabel
            // 
            parts_orderedLabel.AutoSize = true;
            parts_orderedLabel.Location = new System.Drawing.Point(49, 137);
            parts_orderedLabel.Name = "parts_orderedLabel";
            parts_orderedLabel.Size = new System.Drawing.Size(73, 13);
            parts_orderedLabel.TabIndex = 9;
            parts_orderedLabel.Text = "Parts ordered:";
            // 
            // can_be_applied_toLabel
            // 
            can_be_applied_toLabel.AutoSize = true;
            can_be_applied_toLabel.Location = new System.Drawing.Point(49, 163);
            can_be_applied_toLabel.Name = "can_be_applied_toLabel";
            can_be_applied_toLabel.Size = new System.Drawing.Size(93, 13);
            can_be_applied_toLabel.TabIndex = 11;
            can_be_applied_toLabel.Text = "Can be applied to:";
            // 
            // joesAutomotiveDataSet
            // 
            this.joesAutomotiveDataSet.DataSetName = "joesAutomotiveDataSet";
            this.joesAutomotiveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.joesAutomotiveDataSet;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = this.partsTableAdapter;
            this.tableAdapterManager.UpdateOrder = joesAutomotiveCRM.joesAutomotiveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // partsBindingNavigator
            // 
            this.partsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partsBindingNavigator.BindingSource = this.partsBindingSource;
            this.partsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.partsBindingNavigatorSaveItem});
            this.partsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partsBindingNavigator.Name = "partsBindingNavigator";
            this.partsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partsBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.partsBindingNavigator.TabIndex = 0;
            this.partsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // partsBindingNavigatorSaveItem
            // 
            this.partsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partsBindingNavigatorSaveItem.Image")));
            this.partsBindingNavigatorSaveItem.Name = "partsBindingNavigatorSaveItem";
            this.partsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partsBindingNavigatorSaveItem.Text = "Save Data";
            this.partsBindingNavigatorSaveItem.Click += new System.EventHandler(this.partsBindingNavigatorSaveItem_Click);
            // 
            // part_IDTextBox
            // 
            this.part_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part ID", true));
            this.part_IDTextBox.Location = new System.Drawing.Point(148, 30);
            this.part_IDTextBox.Name = "part_IDTextBox";
            this.part_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_IDTextBox.TabIndex = 2;
            // 
            // part_nameTextBox
            // 
            this.part_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part name", true));
            this.part_nameTextBox.Location = new System.Drawing.Point(148, 56);
            this.part_nameTextBox.Name = "part_nameTextBox";
            this.part_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_nameTextBox.TabIndex = 4;
            // 
            // part_costTextBox
            // 
            this.part_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Part cost", true));
            this.part_costTextBox.Location = new System.Drawing.Point(148, 82);
            this.part_costTextBox.Name = "part_costTextBox";
            this.part_costTextBox.Size = new System.Drawing.Size(100, 20);
            this.part_costTextBox.TabIndex = 6;
            // 
            // parts_in_stockTextBox
            // 
            this.parts_in_stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Parts in stock", true));
            this.parts_in_stockTextBox.Location = new System.Drawing.Point(148, 108);
            this.parts_in_stockTextBox.Name = "parts_in_stockTextBox";
            this.parts_in_stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_in_stockTextBox.TabIndex = 8;
            // 
            // parts_orderedTextBox
            // 
            this.parts_orderedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Parts ordered", true));
            this.parts_orderedTextBox.Location = new System.Drawing.Point(148, 134);
            this.parts_orderedTextBox.Name = "parts_orderedTextBox";
            this.parts_orderedTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_orderedTextBox.TabIndex = 10;
            // 
            // can_be_applied_toTextBox
            // 
            this.can_be_applied_toTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsBindingSource, "Can be applied to", true));
            this.can_be_applied_toTextBox.Location = new System.Drawing.Point(148, 160);
            this.can_be_applied_toTextBox.Name = "can_be_applied_toTextBox";
            this.can_be_applied_toTextBox.Size = new System.Drawing.Size(100, 20);
            this.can_be_applied_toTextBox.TabIndex = 12;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(197, 198);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // partsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.backButton);
            this.Controls.Add(part_IDLabel);
            this.Controls.Add(this.part_IDTextBox);
            this.Controls.Add(part_nameLabel);
            this.Controls.Add(this.part_nameTextBox);
            this.Controls.Add(part_costLabel);
            this.Controls.Add(this.part_costTextBox);
            this.Controls.Add(parts_in_stockLabel);
            this.Controls.Add(this.parts_in_stockTextBox);
            this.Controls.Add(parts_orderedLabel);
            this.Controls.Add(this.parts_orderedTextBox);
            this.Controls.Add(can_be_applied_toLabel);
            this.Controls.Add(this.can_be_applied_toTextBox);
            this.Controls.Add(this.partsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "partsDetails";
            this.Text = "Part Details";
            this.Load += new System.EventHandler(this.partsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.joesAutomotiveDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingNavigator)).EndInit();
            this.partsBindingNavigator.ResumeLayout(false);
            this.partsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private joesAutomotiveDataSet joesAutomotiveDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private joesAutomotiveDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private joesAutomotiveDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton partsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox part_IDTextBox;
        private System.Windows.Forms.TextBox part_nameTextBox;
        private System.Windows.Forms.TextBox part_costTextBox;
        private System.Windows.Forms.TextBox parts_in_stockTextBox;
        private System.Windows.Forms.TextBox parts_orderedTextBox;
        private System.Windows.Forms.TextBox can_be_applied_toTextBox;
        private System.Windows.Forms.Button backButton;
    }
}