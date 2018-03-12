namespace joesAutomotiveCRM
{
    partial class vehicleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehicleDetails));
            this.backButton = new System.Windows.Forms.Button();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMake = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.listBoxInvoices = new System.Windows.Forms.ListBox();
            this.listBoxPartsAvailable = new System.Windows.Forms.ListBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(266, 236);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // vehicleButton
            // 
            this.vehicleButton.Location = new System.Drawing.Point(174, 236);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(86, 23);
            this.vehicleButton.TabIndex = 1;
            this.vehicleButton.Text = "Show Owner";
            this.vehicleButton.UseVisualStyleBackColor = true;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 98);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelMake
            // 
            this.labelMake.AutoSize = true;
            this.labelMake.Location = new System.Drawing.Point(147, 13);
            this.labelMake.Name = "labelMake";
            this.labelMake.Size = new System.Drawing.Size(37, 13);
            this.labelMake.TabIndex = 3;
            this.labelMake.Text = "Make:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(147, 39);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(39, 13);
            this.labelModel.TabIndex = 4;
            this.labelModel.Text = "Model:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(147, 64);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Year:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(147, 91);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(34, 13);
            this.labelColor.TabIndex = 9;
            this.labelColor.Text = "Color:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(156, 213);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Owner\'s Name:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 236);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(93, 236);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(191, 10);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(150, 20);
            this.txtMake.TabIndex = 15;
            this.txtMake.Text = "error";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(191, 36);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 20);
            this.txtModel.TabIndex = 16;
            this.txtModel.Text = "error";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(191, 61);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 20);
            this.txtYear.TabIndex = 17;
            this.txtYear.Text = "error";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(191, 88);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(150, 20);
            this.txtColor.TabIndex = 18;
            this.txtColor.Text = "error";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "error";
            // 
            // listBoxInvoices
            // 
            this.listBoxInvoices.FormattingEnabled = true;
            this.listBoxInvoices.Location = new System.Drawing.Point(13, 163);
            this.listBoxInvoices.Name = "listBoxInvoices";
            this.listBoxInvoices.Size = new System.Drawing.Size(328, 43);
            this.listBoxInvoices.TabIndex = 20;
            // 
            // listBoxPartsAvailable
            // 
            this.listBoxPartsAvailable.FormattingEnabled = true;
            this.listBoxPartsAvailable.Location = new System.Drawing.Point(12, 114);
            this.listBoxPartsAvailable.Name = "listBoxPartsAvailable";
            this.listBoxPartsAvailable.Size = new System.Drawing.Size(328, 43);
            this.listBoxPartsAvailable.TabIndex = 21;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(348, 10);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(35, 13);
            this.labelNotes.TabIndex = 22;
            this.labelNotes.Text = "Notes";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(351, 27);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(199, 230);
            this.richTextBoxNotes.TabIndex = 23;
            this.richTextBoxNotes.Text = "";
            // 
            // vehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 269);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.listBoxPartsAvailable);
            this.Controls.Add(this.listBoxInvoices);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelMake);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vehicleButton);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vehicleDetails";
            this.Text = "error";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMake;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox listBoxInvoices;
        private System.Windows.Forms.ListBox listBoxPartsAvailable;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
    }
}