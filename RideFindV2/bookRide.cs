using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using dBHelperC;

namespace RideFindV2
{
    public partial class bookRide : Form
    {
        public static string email = "";
        public bookRide(string ID)
        {
            email = ID;
            InitializeComponent();
        }

        private void bookRideButton_Click(object sender, EventArgs e)
        {

            string rideID = rideIDBox.Text;
            if (rideID == "")
                MessageBox.Show("You must provide a valid ride ID.", "Blank Field!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    int rideNum = Convert.ToInt32(rideID);
                    // call dbHelper to check the number of seats left.
                    // If enough seats left, db books it for you. Else, throws an exception which is handled by this try catch.
                    //dBHelper db = new dBHelper();
                    //db.bookARide(rideNum, email);
                    MessageBox.Show("Ride booked successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No seats left! Please find another ride.", "Too Late!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
