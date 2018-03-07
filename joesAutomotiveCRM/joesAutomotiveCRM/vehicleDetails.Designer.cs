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
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(344, 226);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // vehicleButton
            // 
            this.vehicleButton.Location = new System.Drawing.Point(252, 226);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(86, 23);
            this.vehicleButton.TabIndex = 1;
            this.vehicleButton.Text = "Show Owner";
            this.vehicleButton.UseVisualStyleBackColor = true;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // vehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 261);
            this.Controls.Add(this.vehicleButton);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vehicleDetails";
            this.Text = "error";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button vehicleButton;
    }
}