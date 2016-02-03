namespace RideFindV2
{
    partial class CreateRide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRide));
            this.fromCity = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.commuteFromLabel = new System.Windows.Forms.Label();
            this.toCity = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.minuteBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seatsBox = new System.Windows.Forms.ComboBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costBox = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.postRideButton = new System.Windows.Forms.Button();
            this.fromAddress = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.toAddress = new ChreneLib.Controls.TextBoxes.CTextBox();
            this.SuspendLayout();
            // 
            // fromCity
            // 
            this.fromCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fromCity.Location = new System.Drawing.Point(670, 185);
            this.fromCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromCity.Name = "fromCity";
            this.fromCity.Size = new System.Drawing.Size(194, 26);
            this.fromCity.TabIndex = 1;
            this.fromCity.WaterMark = "City";
            this.fromCity.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.fromCity.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fromCity.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // commuteFromLabel
            // 
            this.commuteFromLabel.AutoSize = true;
            this.commuteFromLabel.BackColor = System.Drawing.Color.Transparent;
            this.commuteFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.commuteFromLabel.ForeColor = System.Drawing.Color.White;
            this.commuteFromLabel.Location = new System.Drawing.Point(559, 150);
            this.commuteFromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commuteFromLabel.Name = "commuteFromLabel";
            this.commuteFromLabel.Size = new System.Drawing.Size(147, 25);
            this.commuteFromLabel.TabIndex = 14;
            this.commuteFromLabel.Text = "Commute From";
            // 
            // toCity
            // 
            this.toCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toCity.Location = new System.Drawing.Point(670, 266);
            this.toCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toCity.Name = "toCity";
            this.toCity.Size = new System.Drawing.Size(194, 26);
            this.toCity.TabIndex = 3;
            this.toCity.WaterMark = "City";
            this.toCity.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.toCity.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toCity.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.BackColor = System.Drawing.Color.Transparent;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toLabel.ForeColor = System.Drawing.Color.White;
            this.toLabel.Location = new System.Drawing.Point(571, 231);
            this.toLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(126, 25);
            this.toLabel.TabIndex = 7;
            this.toLabel.Text = "Commute To";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(603, 313);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(53, 25);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date";
            // 
            // dayBox
            // 
            this.dayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayBox.Location = new System.Drawing.Point(411, 348);
            this.dayBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(105, 28);
            this.dayBox.TabIndex = 4;
            // 
            // monthBox
            // 
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "Februrary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(545, 348);
            this.monthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(172, 28);
            this.monthBox.TabIndex = 5;
            // 
            // yearBox
            // 
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.yearBox.Location = new System.Drawing.Point(749, 348);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(115, 28);
            this.yearBox.TabIndex = 6;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(559, 386);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(168, 25);
            this.timeLabel.TabIndex = 13;
            this.timeLabel.Text = "Time of Departure";
            // 
            // hourBox
            // 
            this.hourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hourBox.Location = new System.Drawing.Point(512, 421);
            this.hourBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(105, 28);
            this.hourBox.TabIndex = 7;
            // 
            // minuteBox
            // 
            this.minuteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minuteBox.FormattingEnabled = true;
            this.minuteBox.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.minuteBox.Location = new System.Drawing.Point(656, 422);
            this.minuteBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(109, 28);
            this.minuteBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(627, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(571, 459);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seats Available";
            // 
            // seatsBox
            // 
            this.seatsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seatsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.seatsBox.FormattingEnabled = true;
            this.seatsBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.seatsBox.Location = new System.Drawing.Point(411, 494);
            this.seatsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seatsBox.Name = "seatsBox";
            this.seatsBox.Size = new System.Drawing.Size(453, 28);
            this.seatsBox.TabIndex = 9;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.BackColor = System.Drawing.Color.Transparent;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.costLabel.ForeColor = System.Drawing.Color.White;
            this.costLabel.Location = new System.Drawing.Point(605, 532);
            this.costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(53, 25);
            this.costLabel.TabIndex = 13;
            this.costLabel.Text = "Cost";
            // 
            // costBox
            // 
            this.costBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.costBox.Location = new System.Drawing.Point(411, 566);
            this.costBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(453, 26);
            this.costBox.TabIndex = 10;
            this.costBox.WaterMark = "20";
            this.costBox.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.costBox.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.costBox.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // postRideButton
            // 
            this.postRideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.postRideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postRideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postRideButton.ForeColor = System.Drawing.Color.White;
            this.postRideButton.Location = new System.Drawing.Point(553, 649);
            this.postRideButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postRideButton.Name = "postRideButton";
            this.postRideButton.Size = new System.Drawing.Size(165, 53);
            this.postRideButton.TabIndex = 11;
            this.postRideButton.Text = "Create Ride";
            this.postRideButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.postRideButton.UseVisualStyleBackColor = false;
            this.postRideButton.Click += new System.EventHandler(this.postRideButton_Click);
            // 
            // fromAddress
            // 
            this.fromAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fromAddress.Location = new System.Drawing.Point(411, 185);
            this.fromAddress.Margin = new System.Windows.Forms.Padding(4);
            this.fromAddress.Name = "fromAddress";
            this.fromAddress.Size = new System.Drawing.Size(234, 26);
            this.fromAddress.TabIndex = 0;
            this.fromAddress.WaterMark = "99 University Avenue";
            this.fromAddress.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.fromAddress.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fromAddress.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // toAddress
            // 
            this.toAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toAddress.Location = new System.Drawing.Point(411, 266);
            this.toAddress.Margin = new System.Windows.Forms.Padding(4);
            this.toAddress.Name = "toAddress";
            this.toAddress.Size = new System.Drawing.Size(234, 26);
            this.toAddress.TabIndex = 2;
            this.toAddress.WaterMark = "Address 2";
            this.toAddress.WaterMarkActiveForeColor = System.Drawing.Color.Gray;
            this.toAddress.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.toAddress.WaterMarkForeColor = System.Drawing.Color.LightGray;
            // 
            // CreateRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RideFindV2.Properties.Resources.createRide;
            this.ClientSize = new System.Drawing.Size(1377, 795);
            this.Controls.Add(this.toAddress);
            this.Controls.Add(this.fromAddress);
            this.Controls.Add(this.postRideButton);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.seatsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.toCity);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromCity);
            this.Controls.Add(this.commuteFromLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CreateRide";
            this.Text = "Create Ride";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label commuteFromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.ComboBox minuteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox seatsBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button postRideButton;
        private ChreneLib.Controls.TextBoxes.CTextBox fromCity;
        private ChreneLib.Controls.TextBoxes.CTextBox toCity;
        private ChreneLib.Controls.TextBoxes.CTextBox costBox;
        private ChreneLib.Controls.TextBoxes.CTextBox fromAddress;
        private ChreneLib.Controls.TextBoxes.CTextBox toAddress;
    }
}