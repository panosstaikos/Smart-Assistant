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
    public partial class Thermansi1 : Form
    {
        public Thermansi1()
        {
            InitializeComponent();
        }
        Bitmap gas_tick = Properties.Resources.gas_tick;
        Bitmap gass = Properties.Resources.gass;
        Bitmap oil_tick = Properties.Resources.oil_tick;
        Bitmap oil = Properties.Resources.oil;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Thermansi2 form2 = new Thermansi2();
            form2.Show();
            this.Hide();
        }
        //new form
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Thermansi2 form2 = new Thermansi2();
            form2.Show();
            this.Hide();
        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Thermansi2 form2 = new Thermansi2();
            form2.Show();
            this.Hide();
        }
        
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Thermansi2 form2 = new Thermansi2();
            form2.Show();
            this.Hide();
        }
        //change photo
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == gass)
            {
                pictureBox9.Image = gas_tick;
                pictureBox13.Image = oil;
            }
            else
            {
                pictureBox9.Image = gass;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image == gass)
            {
                pictureBox10.Image = gas_tick;
                pictureBox14.Image = oil;
            }
            else
            {
                pictureBox10.Image = gass;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image == gass)
            {
                pictureBox11.Image = gas_tick;
                pictureBox15.Image = oil;
            }
            else
            {
                pictureBox11.Image = gass;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image == gass)
            {
                pictureBox12.Image = gas_tick;
                pictureBox16.Image = oil;
            }
            else
            {
                pictureBox12.Image = gass;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image == oil)
            {
                pictureBox13.Image = oil_tick;
                pictureBox9.Image = gass;
            }
            else
            {
                pictureBox13.Image = oil;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox14.Image == oil)
            {
                pictureBox14.Image = oil_tick;
                pictureBox10.Image = gass;
            }
            else
            {
                pictureBox14.Image = oil;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox15.Image == oil)
            {
                pictureBox15.Image = oil_tick;
                pictureBox11.Image = gass;
            }
            else
            {
                pictureBox15.Image = oil;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox16.Image == oil)
            {
                pictureBox16.Image = oil_tick;
                pictureBox12.Image = gass;
            }
            else
            {
                pictureBox16.Image = oil;
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            HouseForm house_form = new HouseForm();
            house_form.Show();
            this.Close();
        }
    }
}
