using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserC;
using RideC;
using dbhelp;

namespace RideFindV2
{
    public partial class RideFind : Form
    {
        public static string email = "";
        public RideFind()
        {
            InitializeComponent();
        }

        //
        // Key Event Handlers
        //
        private void RideFind_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var myForm = new About();
                myForm.Show();
            }
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            dBHelper db = new dBHelper();
            db.Connect();
            //if (true) { 
            if(db.authentication(emailBox.Text,passwordBox.Text)){
               //User user = new User() but not actually
            //if(emailBox.Text == "11mep12" && passwordBox.Text == "hi") { 
                logoPanel.Hide();
                signinButton.Hide();
                Email.Hide();
                emailBox.Hide();
                Password.Hide();
                passwordBox.Hide();
                signInLabel.Hide();
                topPanel.Visible = true;
                logoPanelRight.Visible = true;
                leftPanel.Visible = true;
                signUpButton.Hide();
                listingPanel.Visible = true;
                email = emailBox.Text;
                //db.disconnect();
           }
            else
            {
                MessageBox.Show("Invalid Entry! Try Again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void createRideButton_Click(object sender, EventArgs e)
        {
            
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinButton_Click(sender, (EventArgs)e);

            }
        }

        private void userButtonClick(object sender, EventArgs e)
        {
            //Username Button Click Stuff Here
        }

        private void browseButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void myRidesButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Coming Soon in V2.1! \n;)", "SURPRISE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void myProfileLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Coming Soon in V2.1! \n;)", "SURPRISE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addRideButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new CreateRide(email);
            myForm.Show();
        }

        private void manageRideButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Coming Soon in V2.1! \n;)", "SURPRISE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createRideButton_Click_1(object sender, EventArgs e)
        {
            var myForm = new CreateRide(email);
            myForm.Show();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {

            string ontarioCities = "'Ajax', 'Halton', 'Peterborough', 'Atikokan', 'Halton Hills', 'Pickering', 'Barrie', 'Hamilton', 'Port Bruce', 'Belleville', 'Hamilton-Wentworth', 'Port Burwell', 'Blandford-Blenheim', 'Hearst', 'Port Colborne', 'Blind River', 'Huntsville', 'Port Hope', 'Brampton', 'Ingersoll', 'Prince Edward', 'Brant', 'James', 'Quinte West', 'Brantford', 'Kanata', 'Renfrew', 'Brock', 'Kincardine', 'Richmond Hill', 'Brockville', 'King', 'Sarnia', 'Burlington', 'Kingston', 'Sault Ste. Marie', 'Caledon', 'Kirkland Lake', 'Scarborough', 'Cambridge', 'Kitchener', 'Scugog', 'Chatham-Kent', 'Larder Lake', 'Souix Lookout CoC Sioux Lookout', 'Chesterville', 'Leamington', 'Smiths Falls', 'Clarington', 'Lennox-Addington', 'South-West Oxford', 'Cobourg', 'Lincoln', 'St. Catharines', 'Cochrane', 'Lindsay', 'St. Thomas', 'Collingwood', 'London', 'Stoney Creek', 'Cornwall', 'Loyalist Township', 'Stratford', 'Cumberland', 'Markham', 'Sudbury', 'Deep River', 'Metro Toronto', 'Temagami', 'Dundas', 'Merrickville', 'Thorold', 'Durham', 'Milton', 'Thunder Bay', 'Dymond', 'Nepean', 'Tillsonburg', 'Ear Falls', 'Newmarket', 'Timmins', 'East Gwillimbury', 'Niagara', 'Toronto', 'East Zorra-Tavistock', 'Niagara Falls', 'Uxbridge', 'Elgin', 'Niagara-on-the-Lake', 'Vaughan', 'Elliot Lake', 'North Bay', 'Wainfleet', 'Flamborough', 'North Dorchester', 'Wasaga Beach', 'Fort Erie', 'North Dumfries', 'Waterloo', 'Fort Frances', 'North York', 'Waterloo', 'Gananoque', 'Norwich', 'Welland', 'Georgina', 'Oakville', 'Wellesley', 'Glanbrook', 'Orangeville', 'West Carleton', 'Gloucester', 'Orillia', 'West Lincoln', 'Goulbourn', 'Osgoode', 'Whitby', 'Gravenhurst', 'Oshawa', 'Wilmot', 'Grimsby', 'Ottawa', 'Windsor', 'Guelph', 'Ottawa-Carleton', 'Woolwich', 'Haldimand-Norfork', 'Owen Sound', 'York'";
            string errors = "";
            string errors2 = "";

            if (commuteFromBox.Text == "") // destination Check
            {
                errors += "Please enter your pickup location!\n";
            }
            if (commuteToBox.Text == "")
            {
                errors += "Please enter your Destination!\n";
            }

            if (errors == "")
            {
                string city = commuteFromBox.Text.Trim();
                city = city.ToLower();

                string city2 = commuteToBox.Text.Trim();
                city2 = city2.ToLower();

                ontarioCities = ontarioCities.Trim();
                ontarioCities = ontarioCities.ToLower();

                if (!(ontarioCities.Contains(city)))
                {
                    errors2 += "Pickup Location: Invalid Ontario city name\n";
                }
                if (!(ontarioCities.Contains(city2)))
                {
                    errors2 += "Detination Location: Invalid Ontario city name\n";
                }
                if (city == city2)
                {
                    errors2 += "Origin and destination are the same! Don't you want to go somewhere?";
                }
                if (errors2 == "")
                {
                    /*
                     // filter the listing to show only rides that have the same as commuteFromBox and commuteToBox
                      Ride ride = new Ride(DateTime time, seatsBox.Text, costBox.Text, fromBox.Text, toBox.Text, emailId);
                      //TODO update this part, i just used refineListing randomly! 
                      if (!ride.refineListing()) {
                          MessageBox.Show("Listing could not be refined", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      }

                      this.Close();
                      */
                }
            }
            if (errors != "")
                MessageBox.Show(errors, "Sorry! Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (errors2 != "")
                MessageBox.Show(errors2, "Sorry! Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var myForm = new SignUp();
            myForm.Show();
        }

        private void browseIconButton_Click(object sender, EventArgs e)
        {

        }

        private void myRidesIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon in V2.1! \n;)", "SURPRISE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void myProfileIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon in V2.1! \n;)", "SURPRISE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addRideIconButton_Click(object sender, EventArgs e)
        {
            var myForm = new CreateRide(email);
            myForm.Show();
        }

        private void manageRideIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon in V2.1! \n;)", "SURPRISE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new About();
            myForm.Show();
        }

        private void instructionsF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Instructions();
            myForm.Show();
        }

        private void quitCtrlQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*  for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
              {
                      Application.OpenForms[0].Close();
              } */
            logoPanel.Visible = true;
            signinButton.Visible = true;
            Email.Visible = true;
            emailBox.Visible = true;
            Password.Visible = true;
            passwordBox.Visible = true;
            signInLabel.Visible = true;
            topPanel.Hide(); ;
            logoPanelRight.Hide();
            leftPanel.Hide();
            signUpButton.Visible = true;
            listingPanel.Hide();
            emailBox.Text = "";
            passwordBox.Text = "";
        }

        private void bookRideIconButton_Click(object sender, EventArgs e)
        {
            bookRideButton_Click(sender, e);
        }

        private void bookRideButton_Click(object sender, EventArgs e)
        {
            var myForm = new bookRide(email);
            myForm.Show();
        }

        private void reviewButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new Review();
            myForm.Show();
        }

        private void reviewIcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reviewIcon_MouseClick(object sender, MouseEventArgs e)
        {
            var myForm = new Review();
            myForm.Show();
        }
    }
}
