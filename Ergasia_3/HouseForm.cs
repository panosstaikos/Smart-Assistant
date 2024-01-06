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
    public partial class HouseForm : Form
    {
        public HouseForm()
        {
            InitializeComponent();
        }


        //Μενού το οποίο περιέχει τις λειτουργίες του σπιτιού
        private void HouseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        private void houseButton_Click(object sender, EventArgs e)
        {
            Light light = new Light();
            light.Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void planButton_Click(object sender, EventArgs e)
        {
            Thermansi1 thermansi1 = new Thermansi1();
            thermansi1.Show();
            this.Close();
        }

        private void petButton_Click(object sender, EventArgs e)
        {
            Shoe1 shoe1 = new Shoe1();
            shoe1.Show();
            this.Close();
        }

    }
}
