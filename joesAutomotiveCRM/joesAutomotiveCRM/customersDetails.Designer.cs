namespace joesAutomotiveCRM
{
    partial class customersDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customersDetails));
            this.backButton = new System.Windows.Forms.Button();
            this.vehiclesListBox = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddressLn2 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.invoicesListBox = new System.Windows.Forms.ListBox();
            this.buttonNewVehicle = new System.Windows.Forms.Button();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(361, 318);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // vehiclesListBox
            // 
            this.vehiclesListBox.FormattingEnabled = true;
            this.vehiclesListBox.Location = new System.Drawing.Point(12, 168);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(424, 69);
            this.vehiclesListBox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(139, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name: ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(129, 41);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone #:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(132, 119);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address:";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 318);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(94, 318);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // vehicleButton
            // 
            this.vehicleButton.Location = new System.Drawing.Point(267, 318);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(88, 23);
            this.vehicleButton.TabIndex = 15;
            this.vehicleButton.Text = "Show Vehicle";
            this.vehicleButton.UseVisualStyleBackColor = true;
            this.vehicleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtAddressLn2
            // 
            this.txtAddressLn2.Location = new System.Drawing.Point(186, 142);
            this.txtAddressLn2.Name = "txtAddressLn2";
            this.txtAddressLn2.Size = new System.Drawing.Size(120, 20);
            this.txtAddressLn2.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(186, 116);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(120, 20);
            this.txtAddress.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(186, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(132, 93);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email:";
            // 
            // invoicesListBox
            // 
            this.invoicesListBox.FormattingEnabled = true;
            this.invoicesListBox.Location = new System.Drawing.Point(12, 243);
            this.invoicesListBox.Name = "invoicesListBox";
            this.invoicesListBox.Size = new System.Drawing.Size(424, 69);
            this.invoicesListBox.TabIndex = 23;
            // 
            // buttonNewVehicle
            // 
            this.buttonNewVehicle.Location = new System.Drawing.Point(175, 318);
            this.buttonNewVehicle.Name = "buttonNewVehicle";
            this.buttonNewVehicle.Size = new System.Drawing.Size(86, 23);
            this.buttonNewVehicle.TabIndex = 24;
            this.buttonNewVehicle.Text = "New Vehicle";
            this.buttonNewVehicle.UseVisualStyleBackColor = true;
            this.buttonNewVehicle.Click += new System.EventHandler(this.buttonNewVehicle_Click);
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(312, 31);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(124, 131);
            this.richTextBoxNotes.TabIndex = 26;
            this.richTextBoxNotes.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(186, 38);
            this.txtPhone.Mask = "000-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 20);
            this.txtPhone.TabIndex = 27;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(186, 64);
            this.txtPhone2.Mask = "000-000-0000";
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(120, 20);
            this.txtPhone2.TabIndex = 28;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(312, 14);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(35, 13);
            this.labelNotes.TabIndex = 29;
            this.labelNotes.Text = "Notes";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(13, 140);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(112, 23);
            this.buttonUpload.TabIndex = 30;
            this.buttonUpload.Text = "Change Image";
            this.buttonUpload.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(111, 124);
            this.pictureBoxCustomer.TabIndex = 25;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // customersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 349);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Controls.Add(this.buttonNewVehicle);
            this.Controls.Add(this.invoicesListBox);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtAddressLn2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.vehicleButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.vehiclesListBox);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customersDetails";
            this.Text = "error";
            this.Load += new System.EventHandler(this.customersDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddressLn2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ListBox invoicesListBox;
        private System.Windows.Forms.Button buttonNewVehicle;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtPhone2;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
    }
}