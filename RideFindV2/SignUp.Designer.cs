namespace RideFindV2
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.lastNameBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.locationBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.profileLabel = new System.Windows.Forms.Label();
            this.profileBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.signupButton = new System.Windows.Forms.Button();
            this.driverCheck = new System.Windows.Forms.CheckBox();
            this.helpButton = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Oxygen", 12F);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(713, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Oxygen", 10F);
            this.firstNameBox.Location = new System.Drawing.Point(718, 138);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(167, 35);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.WaterMark = "First";
            this.firstNameBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.firstNameBox.WaterMarkFont = new System.Drawing.Font("Oxygen", 12F);
            this.firstNameBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Oxygen", 10F);
            this.lastNameBox.Location = new System.Drawing.Point(891, 138);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(168, 35);
            this.lastNameBox.TabIndex = 2;
            this.lastNameBox.WaterMark = "Last";
            this.lastNameBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.lastNameBox.WaterMarkFont = new System.Drawing.Font("Oxygen", 12F);
            this.lastNameBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Oxygen", 12F);
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(713, 176);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(114, 25);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Student E-Mail";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Oxygen", 10F);
            this.emailBox.Location = new System.Drawing.Point(718, 204);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(341, 35);
            this.emailBox.TabIndex = 4;
            this.emailBox.WaterMark = "netid@queensu.ca";
            this.emailBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.emailBox.WaterMarkFont = new System.Drawing.Font("Oxygen", 12F);
            this.emailBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Oxygen", 12F);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(713, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(145, 25);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Choose a Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Oxygen", 10F);
            this.passwordBox.Location = new System.Drawing.Point(718, 270);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(341, 35);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.WaterMark = "Don\'t use 123456..";
            this.passwordBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.passwordBox.WaterMarkFont = new System.Drawing.Font("Oxygen", 12F);
            this.passwordBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Oxygen", 12F);
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(713, 308);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(138, 25);
            this.confirmPasswordLabel.TabIndex = 7;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmBox
            // 
            this.confirmBox.Font = new System.Drawing.Font("Oxygen", 10F);
            this.confirmBox.Location = new System.Drawing.Point(718, 336);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.PasswordChar = '*';
            this.confirmBox.Size = new System.Drawing.Size(341, 35);
            this.confirmBox.TabIndex = 8;
            this.confirmBox.WaterMark = "Confirm Password";
            this.confirmBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.confirmBox.WaterMarkFont = new System.Drawing.Font("Oxygen", 12F);
            this.confirmBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Oxygen", 10F);
            this.locationBox.Location = new System.Drawing.Point(718, 402);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(341, 35);
            this.locationBox.TabIndex = 10;
            this.locationBox.WaterMark = "Kingston, ON";
            this.locationBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.locationBox.WaterMarkFont = new System.Drawing.Font("Oxygen", 12F);
            this.locationBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Font = new System.Drawing.Font("Oxygen", 12F);
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(713, 374);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(71, 25);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Location";
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.BackColor = System.Drawing.Color.Transparent;
            this.profileLabel.Font = new System.Drawing.Font("Oxygen", 12F);
            this.profileLabel.ForeColor = System.Drawing.Color.White;
            this.profileLabel.Location = new System.Drawing.Point(713, 440);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(106, 25);
            this.profileLabel.TabIndex = 11;
            this.profileLabel.Text = "Profile Picture";
            // 
            // profileBox
            // 
            this.profileBox.Font = new System.Drawing.Font("Oxygen", 11F);
            this.profileBox.FormattingEnabled = true;
            this.profileBox.Location = new System.Drawing.Point(718, 468);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(341, 31);
            this.profileBox.TabIndex = 12;
            this.profileBox.Click += new System.EventHandler(this.profileBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFile";
            // 
            // signupButton
            // 
            this.signupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupButton.Font = new System.Drawing.Font("Oxygen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupButton.ForeColor = System.Drawing.Color.White;
            this.signupButton.Location = new System.Drawing.Point(960, 553);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(99, 40);
            this.signupButton.TabIndex = 16;
            this.signupButton.Text = "Sign Up!";
            this.signupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // driverCheck
            // 
            this.driverCheck.AutoSize = true;
            this.driverCheck.BackColor = System.Drawing.Color.Transparent;
            this.driverCheck.Font = new System.Drawing.Font("Oxygen", 12F);
            this.driverCheck.ForeColor = System.Drawing.Color.White;
            this.driverCheck.Location = new System.Drawing.Point(718, 514);
            this.driverCheck.Name = "driverCheck";
            this.driverCheck.Size = new System.Drawing.Size(131, 29);
            this.driverCheck.TabIndex = 17;
            this.driverCheck.Text = "I own a vehicle";
            this.driverCheck.UseVisualStyleBackColor = false;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.BackgroundImage = global::RideFindV2.Properties.Resources.questions1;
            this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpButton.Location = new System.Drawing.Point(844, 514);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(32, 33);
            this.helpButton.TabIndex = 18;
            this.helpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.helpButton_MouseClick);
            this.helpButton.MouseLeave += new System.EventHandler(this.helpButton_MouseLeave);
            this.helpButton.MouseHover += new System.EventHandler(this.helpButton_MouseHover);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RideFindV2.Properties.Resources.SignInPage1;
            this.ClientSize = new System.Drawing.Size(1214, 616);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.driverCheck);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.profileLabel);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "Sign Up - RideFind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private ChreneLib.Controls.TextBoxes.CTextBox firstNameBox;
        private ChreneLib.Controls.TextBoxes.CTextBox lastNameBox;
        private System.Windows.Forms.Label emailLabel;
        private ChreneLib.Controls.TextBoxes.CTextBox emailBox;
        private System.Windows.Forms.Label passwordLabel;
        private ChreneLib.Controls.TextBoxes.CTextBox passwordBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private ChreneLib.Controls.TextBoxes.CTextBox confirmBox;
        private ChreneLib.Controls.TextBoxes.CTextBox locationBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.ComboBox profileBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.CheckBox driverCheck;
        private System.Windows.Forms.Panel helpButton;
    }
}