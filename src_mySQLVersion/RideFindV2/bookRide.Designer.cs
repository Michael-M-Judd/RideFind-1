namespace RideFindV2
{
    partial class bookRide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookRide));
            this.label1 = new System.Windows.Forms.Label();
            this.rideIDBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookRideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oxygen", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Ride ID:";
            // 
            // rideIDBox
            // 
            this.rideIDBox.Font = new System.Drawing.Font("Oxygen", 11F);
            this.rideIDBox.Location = new System.Drawing.Point(224, 145);
            this.rideIDBox.Name = "rideIDBox";
            this.rideIDBox.Size = new System.Drawing.Size(180, 38);
            this.rideIDBox.TabIndex = 1;
            this.rideIDBox.WaterMark = "105912";
            this.rideIDBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.rideIDBox.WaterMarkFont = new System.Drawing.Font("Oxygen", 12F);
            this.rideIDBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::RideFindV2.Properties.Resources.Test1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(69, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 100);
            this.panel1.TabIndex = 2;
            // 
            // bookRideButton
            // 
            this.bookRideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookRideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookRideButton.Font = new System.Drawing.Font("Oxygen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookRideButton.ForeColor = System.Drawing.Color.White;
            this.bookRideButton.Location = new System.Drawing.Point(151, 221);
            this.bookRideButton.Name = "bookRideButton";
            this.bookRideButton.Size = new System.Drawing.Size(124, 43);
            this.bookRideButton.TabIndex = 13;
            this.bookRideButton.Text = "Book Ride!";
            this.bookRideButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bookRideButton.UseVisualStyleBackColor = false;
            this.bookRideButton.Click += new System.EventHandler(this.bookRideButton_Click);
            // 
            // bookRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RideFindV2.Properties.Resources.bACKGROUND1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 298);
            this.Controls.Add(this.bookRideButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rideIDBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "bookRide";
            this.Text = "bookRide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bookRideButton;
        private ChreneLib.Controls.TextBoxes.CTextBox rideIDBox;
    }
}