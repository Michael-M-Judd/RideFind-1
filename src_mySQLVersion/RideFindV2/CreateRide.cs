using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RideC;
namespace RideFindV2
{

    public partial class CreateRide : Form
    {
        public static string emailId = "";
        public CreateRide(string ID)
        {
            emailId = ID;
            InitializeComponent();
        }

        private void postRideButton_Click(object sender, EventArgs e)
        {
            string postTime = "";

            string wordMonth = monthBox.Text;
            string month = "";
            switch (wordMonth)
            {
                case "January":
                    month = "01";
                    break;
                case "February":
                    month = "02";
                    break;
                case "March":
                    month = "03";
                    break;
                case "April":
                    month = "04";
                    break;
                case "May":
                    month = "05";
                    break;
                case "June ":
                    month = "06";
                    break;
                case "July":
                    month = "07";
                    break;
                case "August":
                    month = "08";
                    break;
                case "September":
                    month = "09";
                    break;
                case "October":
                    month = "10";
                    break;
                case "November":
                    month = "11";
                    break;
                case "December":
                    month = "12";
                    break;
            }//End switch statement 
            // Converting to DateTime
            if (monthBox.Text == "" || dayBox.Text == "" || yearBox.Text == "" || hourBox.Text == "" || minuteBox.Text == "")
                MessageBox.Show("You've left fields blank.", "Sorry! Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                postTime += month + "/" + dayBox.Text + "/" + yearBox.Text + " " + hourBox.Text + ":" + minuteBox.Text + ":00";
                Console.WriteLine(postTime);
                DateTime dt = DateTime.Parse(postTime); // Posting Time in DateTime format

                string ontarioCities = "'Ajax', 'Halton', 'Peterborough', 'Atikokan', 'Halton Hills', 'Pickering', 'Barrie', 'Hamilton', 'Port Bruce', 'Belleville', 'Hamilton-Wentworth', 'Port Burwell', 'Blandford-Blenheim', 'Hearst', 'Port Colborne', 'Blind River', 'Huntsville', 'Port Hope', 'Brampton', 'Ingersoll', 'Prince Edward', 'Brant', 'James', 'Quinte West', 'Brantford', 'Kanata', 'Renfrew', 'Brock', 'Kincardine', 'Richmond Hill', 'Brockville', 'King', 'Sarnia', 'Burlington', 'Kingston', 'Sault Ste. Marie', 'Caledon', 'Kirkland Lake', 'Scarborough', 'Cambridge', 'Kitchener', 'Scugog', 'Chatham-Kent', 'Larder Lake', 'Souix Lookout CoC Sioux Lookout', 'Chesterville', 'Leamington', 'Smiths Falls', 'Clarington', 'Lennox-Addington', 'South-West Oxford', 'Cobourg', 'Lincoln', 'St. Catharines', 'Cochrane', 'Lindsay', 'St. Thomas', 'Collingwood', 'London', 'Stoney Creek', 'Cornwall', 'Loyalist Township', 'Stratford', 'Cumberland', 'Markham', 'Sudbury', 'Deep River', 'Metro Toronto', 'Temagami', 'Dundas', 'Merrickville', 'Thorold', 'Durham', 'Milton', 'Thunder Bay', 'Dymond', 'Nepean', 'Tillsonburg', 'Ear Falls', 'Newmarket', 'Timmins', 'East Gwillimbury', 'Niagara', 'Toronto', 'East Zorra-Tavistock', 'Niagara Falls', 'Uxbridge', 'Elgin', 'Niagara-on-the-Lake', 'Vaughan', 'Elliot Lake', 'North Bay', 'Wainfleet', 'Flamborough', 'North Dorchester', 'Wasaga Beach', 'Fort Erie', 'North Dumfries', 'Waterloo', 'Fort Frances', 'North York', 'Waterloo', 'Gananoque', 'Norwich', 'Welland', 'Georgina', 'Oakville', 'Wellesley', 'Glanbrook', 'Orangeville', 'West Carleton', 'Gloucester', 'Orillia', 'West Lincoln', 'Goulbourn', 'Osgoode', 'Whitby', 'Gravenhurst', 'Oshawa', 'Wilmot', 'Grimsby', 'Ottawa', 'Windsor', 'Guelph', 'Ottawa-Carleton', 'Woolwich', 'Haldimand-Norfork', 'Owen Sound', 'York'";
                string errors = "";
                string errors2 = "";
                if (DateTime.Now > dt) // Date Check
                {
                    errors += "The date you entered is not valid, please enter a future date.\n";
                }

                if (fromCity.Text == "") // destination Check
                {
                    errors += "Please enter your pickup location!\n";
                }
                if (toCity.Text == "")
                {
                    errors += "Please enter your Destination!\n";
                }
                int parsedValue;
                if (!int.TryParse(costBox.Text, out parsedValue))
                {
                    errors += "Cost field should be integer only!\n";
                }
                if (errors == "")
                {
                    string city = fromCity.Text.Trim();
                    city = city.ToLower();

                    string city2 = toCity.Text.Trim();
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
                        errors2 += "Origin and destination are the same";
                    }
                    if (errors2 == "")
                    {
                        MessageBox.Show("Ride has been created successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //string d = hourBox.Text + " " + minuteBox.Text + " " + dayBox.Text + " " + monthBox.Text + " " + yearBox.Text;


                        //DateTime rideDate = "d to datetime;
                       /* Ride ride = new Ride(time, seatsBox.Text, costBox.Text, fromBox.Text, toBox.Text, emailId);

                        if (!ride.createRide()) {
                            MessageBox.Show("Ride has not been created successfully", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                        //MessageBox.Show("Ride has been created successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }*/
                        this.Close();
                    }
                }

                if (errors != "")
                    MessageBox.Show(errors, "Sorry! Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (errors2 != "")
                    MessageBox.Show(errors2, "Sorry! Invalid Entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
