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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddressLn2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(361, 226);
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
            this.vehiclesListBox.Location = new System.Drawing.Point(12, 140);
            this.vehiclesListBox.Name = "vehiclesListBox";
            this.vehiclesListBox.Size = new System.Drawing.Size(424, 69);
            this.vehiclesListBox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name: ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 25);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(51, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone #:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(28, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "error";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(78, 25);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(28, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "error";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Location = new System.Drawing.Point(78, 41);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(104, 13);
            this.lblPhone2.TabIndex = 7;
            this.lblPhone2.Text = "no secondary phone";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 57);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(78, 57);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(28, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "error";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblAddressLn2
            // 
            this.lblAddressLn2.AutoSize = true;
            this.lblAddressLn2.Location = new System.Drawing.Point(77, 73);
            this.lblAddressLn2.Name = "lblAddressLn2";
            this.lblAddressLn2.Size = new System.Drawing.Size(0, 13);
            this.lblAddressLn2.TabIndex = 11;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(13, 226);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(94, 226);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // vehicleButton
            // 
            this.vehicleButton.Location = new System.Drawing.Point(267, 226);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(88, 23);
            this.vehicleButton.TabIndex = 15;
            this.vehicleButton.Text = "Show Vehicle";
            this.vehicleButton.UseVisualStyleBackColor = true;
            this.vehicleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // customersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.vehicleButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.lblAddressLn2);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.lblPhone2);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.vehiclesListBox);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customersDetails";
            this.Text = "error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox vehiclesListBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddressLn2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button vehicleButton;
    }
}