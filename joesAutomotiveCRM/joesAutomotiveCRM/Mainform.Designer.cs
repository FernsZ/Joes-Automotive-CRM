namespace joesAutomotiveCRM
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.customersButton = new System.Windows.Forms.Button();
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.invoicesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customersButton
            // 
            this.customersButton.Location = new System.Drawing.Point(13, 6);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(75, 23);
            this.customersButton.TabIndex = 0;
            this.customersButton.Text = "Customers";
            this.customersButton.UseVisualStyleBackColor = true;
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.Location = new System.Drawing.Point(13, 36);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Size = new System.Drawing.Size(75, 23);
            this.vehiclesButton.TabIndex = 1;
            this.vehiclesButton.Text = "Vehicles";
            this.vehiclesButton.UseVisualStyleBackColor = true;
            // 
            // partsButton
            // 
            this.partsButton.Location = new System.Drawing.Point(13, 66);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(75, 23);
            this.partsButton.TabIndex = 2;
            this.partsButton.Text = "Parts";
            this.partsButton.UseVisualStyleBackColor = true;
            // 
            // invoicesButton
            // 
            this.invoicesButton.Location = new System.Drawing.Point(13, 96);
            this.invoicesButton.Name = "invoicesButton";
            this.invoicesButton.Size = new System.Drawing.Size(75, 23);
            this.invoicesButton.TabIndex = 3;
            this.invoicesButton.Text = "Invoices";
            this.invoicesButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::joesAutomotiveCRM.Properties.Resources.car_sedan_car_photo_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(95, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 128);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.invoicesButton);
            this.Controls.Add(this.partsButton);
            this.Controls.Add(this.vehiclesButton);
            this.Controls.Add(this.customersButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "Joe\'s Automotive";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button invoicesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

