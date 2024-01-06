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
    public partial class Light : Form
    {
        //Χρησιμοποιούμε Bitmam για ευκολότερη χρληση των εικόνων που έχουν γίνει import
        //Για κάθε δωμάτιο υπάρχει μια έικόνα με ανοιχτό φως και μια με κλειστό
        Bitmap bathroom_light = Properties.Resources.bathroom;
        Bitmap bathroom_dark = Properties.Resources.bathroom_dark;
        Bitmap kitchen_light = Properties.Resources.kitchen;
        Bitmap kitchen_dark = Properties.Resources.kitchen_dark;
        Bitmap room1_light = Properties.Resources.room1;
        Bitmap room1_dark = Properties.Resources.room1_dark;
        Bitmap room2_light = Properties.Resources.room2;
        Bitmap room2_dark = Properties.Resources.room2_dark;
        Bitmap living_room_light = Properties.Resources.living_room;
        Bitmap living_room_dark = Properties.Resources.living_room_dark;
        Bitmap hallway_light = Properties.Resources.hallway;
        Bitmap hallway_dark = Properties.Resources.hallway_dark;
        public Light()
        {
            InitializeComponent();
        }

       

        private void Light_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        //Αν η εικόνα που έχει πατηθεί είναι η φωτεινή τότε αλλάζει σε σκοτεινή και το αντίστροφο
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == bathroom_light)
            {
                pictureBox1.Image = bathroom_dark;
            }
            else
            {
                pictureBox1.Image = bathroom_light;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == kitchen_light)
            {
                pictureBox2.Image = kitchen_dark;
            }
            else
            {
                pictureBox2.Image = kitchen_light;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image == room1_light)
            {
                pictureBox3.Image = room1_dark;
            }
            else
            {
                pictureBox3.Image = room1_light;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == room2_light)
            {
                pictureBox4.Image = room2_dark;
            }
            else
            {
                pictureBox4.Image = room2_light;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == living_room_light)
            {
                pictureBox5.Image = living_room_dark;
            }
            else
            {
                pictureBox5.Image = living_room_light;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == hallway_light)
            {
                pictureBox6.Image = hallway_dark;
            }
            else
            {
                pictureBox6.Image = hallway_light;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            HouseForm house_form = new HouseForm();
            house_form.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
