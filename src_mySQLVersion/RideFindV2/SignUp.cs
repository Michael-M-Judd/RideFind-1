using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserC;
namespace RideFindV2
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        string fileName = "";
        private void profileBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileName = openFileDialog1.FileName;
            profileBox.Text = fileName;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string name = firstNameBox.Text + " " + lastNameBox.Text;
            string[] ID = {"11mep12@queensu.ca", "12pm30@queensu.ca", "13df@queensu.ca", "12vh6@queensu.ca", "12mmj2@queensu.ca", "1xw8@queensu.ca", "alan.mcleod@queensu.ca", "renee.xu@queensu.ca"};
            string location = locationBox.Text;
            string emailID = "";
            string password = "";
            int check = 0;
            string error = "";

            if(firstNameBox.Text == "" || lastNameBox.Text == "" || passwordBox.Text == "" || confirmBox.Text == "" || emailBox.Text == "" || locationBox.Text == "")
                MessageBox.Show("One of the fields in empty! Please try again!", "Failure!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!emailBox.Text.Contains("@queensu.ca"))
                error += "Only @queensu.ca emails for now, sorry :( \n";
            else
            {
                if ((ID.Contains(emailBox.Text)))
                    emailID = emailBox.Text;
                else
                    error += "Email ID is not in the database. Sorry!";
            }

            if (passwordBox.Text != confirmBox.Text)
                error += "Password was not correctly confirmed. Please try again! \n";
            else
            {
                password = passwordBox.Text;
            }

            if (driverCheck.Checked)
                check = 1;
            else
                check = 0;

            //User user = new User(name, emailBox.Text, passwordBox.Text, locationBox.Text, check);
            // dBHelper db = new dBHelper();
            string add = emailID +"\t"+name+"\t"+password+"\t\t"+check;
            //int created = db.createAUser(user.getName(), user.getEmail(), user.getPassword(), user.driveCheck());
            int created = 0;
            int invalid = 0;
            if (error == "")
            {
                try
                {   // Open the text file using a stream reader.
                    if (!File.Exists(@"c:\Users\Parv\Desktop\Accounts.txt"))
                    {
                        File.Create(@"c:\Users\Parv\Desktop\Accounts.txt").Dispose();
                        using (TextWriter tw = new StreamWriter(@"c:\Users\Parv\Desktop\Accounts.txt"))
                        {
                            tw.WriteLine("NetID\t\t\tName\t\tPassword\tDriverCheck");
                            tw.Close();
                        }
                    }

                    string[] lines = File.ReadAllLines(@"C:\Users\Parv\Desktop\Accounts.txt");
                    // Display the file contents by using a foreach loop.
                    foreach (string line in lines)
                    {
                        // Use a tab to indent each line of the file.
                        if (line.Contains(emailID))
                            invalid = 1;
                    }

                    if (invalid == 0)
                    {
                        StreamWriter swAppend = File.AppendText(@"c:\Users\Parv\Desktop\Accounts.txt");
                        swAppend.WriteLine(add);
                        swAppend.Close();
                        created = 1;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            { 
                MessageBox.Show(error, "Failure!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (created == 0)
            {
                MessageBox.Show("User has not been created successfully", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (error == "")
                {
                    MessageBox.Show("User has been created successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }



            }

        private void helpButton_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void helpButton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void helpButton_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("If you own a car and plan on making rides to make cash moola and save the environment, check this box! You won't be able to change this option later on.", "Help",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
