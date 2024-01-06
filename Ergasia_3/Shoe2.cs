using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia_3
{
    public partial class Shoe2 : Form
    {
        public Shoe2()
        {
            InitializeComponent();
        }
        Bitmap shoes_red = Properties.Resources.shoes_red;
        Bitmap shoes_red_tick = Properties.Resources.shoes_red_tick;
        Bitmap shoes_black = Properties.Resources.shoes_black;
        Bitmap shoes_black_tick = Properties.Resources.shoes_black_tick;
        Bitmap shoes_grey = Properties.Resources.shoes_grey;
        Bitmap shoes_grey_tick = Properties.Resources.shoes_grey_tick;
        Bitmap mens_black = Properties.Resources.mens_black;
        Bitmap mens_black_tick = Properties.Resources.mens_black_tick;
        Bitmap mens_brown = Properties.Resources.mens_brown;
        Bitmap mens_brown_tick = Properties.Resources.mens_brown_tick;
        Bitmap mens_brown2 = Properties.Resources.mens_brown2;
        Bitmap mens_brown2_tick = Properties.Resources.mens_brown2_tick;
        Bitmap running_white = Properties.Resources.running_white;
        Bitmap running_white_tick = Properties.Resources.running_white_tick;
        Bitmap running_grey = Properties.Resources.running_grey;
        Bitmap running_grey_tick = Properties.Resources.running_grey_tick;
        Bitmap running_green = Properties.Resources.running_green;
        Bitmap running_green_tick = Properties.Resources.running_green_tick;
        Bitmap football_white = Properties.Resources.football_white;
        Bitmap football_white_tick = Properties.Resources.football_white_tick;
        Bitmap football_green = Properties.Resources.footbal_green;
        Bitmap football_green_tick = Properties.Resources.football_green_tick;
        Bitmap football_red = Properties.Resources.footbal_red;
        Bitmap football_red_tick = Properties.Resources.football_red_tick;

        public static double sum = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //epilogh tou papoutsioy pou thes na agoraseis
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == shoes_black)
            {
                pictureBox4.Image = shoes_black_tick;
                
            }
            else
            {
                
                pictureBox4.Image = shoes_black;
                
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == shoes_red)
            {
                pictureBox5.Image = shoes_red_tick;
                
            }
            else
            {
                pictureBox5.Image = shoes_red;
                
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == shoes_grey)
            {
                pictureBox6.Image = shoes_grey_tick;
                
            }
            else
            {
                pictureBox6.Image = shoes_grey;
               
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image == mens_brown2)
            {
                pictureBox7.Image = mens_brown2_tick;
                
            }
            else
            {
                pictureBox7.Image = mens_brown2;
                
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image == mens_black)
            {
                pictureBox8.Image = mens_black_tick;
                
            }
            else
            {
                pictureBox8.Image = mens_black;
                
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == mens_brown)
            {
                pictureBox9.Image = mens_brown_tick;
                
            }
            else
            {
                pictureBox9.Image = mens_brown;
                
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image == running_white)
            {
                pictureBox10.Image = running_white_tick;
                
            }
            else
            {
                pictureBox10.Image = running_white;
                
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image == running_green)
            {
                pictureBox11.Image = running_green_tick;
                
            }
            else
            {
                pictureBox11.Image = running_green;
                
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image == running_grey)
            {
                pictureBox12.Image = running_grey_tick;
                
            }
            else
            {
                pictureBox12.Image = running_grey;
                
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == football_white)
            {
                pictureBox13.Image = football_white_tick;
                
            }
            else
            {
                pictureBox13.Image = football_white;
                
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            sum = sum + 109.9;
            if (pictureBox14.Image == football_green)
            {
                pictureBox14.Image = football_green_tick;
                
            }
            else
            {
                pictureBox14.Image = football_green;
                
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            sum = sum + 99.9;
            if (pictureBox15.Image == football_red)
            {
               
                pictureBox15.Image = football_red_tick;
                

            }
            else
            {
                pictureBox15.Image = football_red;
                
                
            }
        }
        //close form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sum = 0;
            //That's because the first click event in a picture box accidentally does not work
            if(pictureBox4.Image == shoes_black_tick)
            {
                sum = sum + 43;
            }
            if (pictureBox5.Image == shoes_red_tick)
            {
                sum = sum + 38.9;
            }
            if (pictureBox6.Image == shoes_grey_tick)
            {
                sum = sum + 65;
            }
            if (pictureBox7.Image == mens_brown2_tick)
            {
                sum = sum + 60;
            }
            if (pictureBox8.Image == mens_black_tick)
            {
                sum = sum + 49.9;
            }
            if (pictureBox9.Image == mens_brown_tick)
            {
                sum = sum + 55;
            }
            if (pictureBox10.Image == running_white_tick)
            {
                sum = sum + 50.9;
            }
            if (pictureBox11.Image == running_green_tick)
            {
                sum = sum + 62;
            }
            if (pictureBox12.Image == running_grey_tick)
            {
                sum = sum + 85;
            }
            if (pictureBox13.Image == football_white_tick)
            {
                sum = sum + 95;
            }
            if (pictureBox14.Image == football_green_tick)
            {
                sum = sum + 109.9;
            }
            if (pictureBox15.Image == football_red_tick)
            {
                sum = sum + 99.9;
            }

            Shoe3 form3 = new Shoe3();
            form3.Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Shoe1 shoe1 = new Shoe1();
            shoe1.Show();
            this.Close();
        }
    }
}
