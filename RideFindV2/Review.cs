using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RideFindV2
{

    public partial class Review : Form
    {
        int isClicked = 0;
        public Review()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.JOHNCENA);
            sp.Play();
        }

        private void Review_Load(object sender, EventArgs e)
        {

        }

        private void star5_MouseEnter(object sender, EventArgs e)
        {
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star5.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star5_MouseLeave(object sender, EventArgs e)
        {
            if (isClicked == 0)
            {
                star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star4.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star5.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            }
        }

        private void star4_MouseEnter(object sender, EventArgs e)
        {
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star4_MouseLeave(object sender, EventArgs e)
        {
            if (isClicked == 0)
            {
                star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star4.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            }
        }

        private void star3_MouseEnter(object sender, EventArgs e)
        {
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star3_MouseLeave(object sender, EventArgs e)
        {
            if (isClicked == 0)
            {
                star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            }
        }

        private void star2_MouseEnter(object sender, EventArgs e)
        {
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star2_MouseLeave(object sender, EventArgs e)
        {
            if (isClicked == 0)
            {
                star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            }
        }

        private void star1_MouseEnter(object sender, EventArgs e)
        {
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star1_MouseLeave(object sender, EventArgs e)
        {
            if(isClicked == 0)
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;

        }

        private void star5_Paint(object sender, PaintEventArgs e)
        {
            //Ignore
        }

        private void star5_MouseClick(object sender, MouseEventArgs e)
        {
            isClicked = 1;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star5.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star5.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star4_MouseClick(object sender, MouseEventArgs e)
        {
            isClicked = 1;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star5.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star3_MouseClick(object sender, MouseEventArgs e)
        {
            isClicked = 1;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star4.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
                star5.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star2_MouseClick(object sender, MouseEventArgs e)
        {
            isClicked = 1;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star5.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void star1_MouseClick(object sender, MouseEventArgs e)
        {
            isClicked = 1;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star2.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star3.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star4.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star5.BackgroundImage = global::RideFindV2.Properties.Resources.favourite241;
            star1.BackgroundImage = global::RideFindV2.Properties.Resources.bookmark501;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have rated your last driver! Thanks for making RideFind a safer place");
            this.Close();
        }
    }
}
