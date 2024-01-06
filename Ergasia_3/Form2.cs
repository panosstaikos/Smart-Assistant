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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
        }

        //Παρουσίαση του κεντρικού μενού
        private void houseButton_Click(object sender, EventArgs e)
        {
            HouseForm houseForm = new HouseForm();
            houseForm.Show();
            this.Hide();
        }

        private void petButton_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void planButton_Click(object sender, EventArgs e)
        {
            SmartAssistant SM = new SmartAssistant();
            SM.Show();
            this.Hide();
        }

        private void δημιουργίαΠλάνουΗμέραςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartAssistant sa = new SmartAssistant();
            sa.Show();
            this.Hide();
        }

        private void έλεγχοςΣπιτιούToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HouseForm hf = new HouseForm();
            hf.Show();
            this.Hide();
        }

        private void αυτόματηΤαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Hide();
        }

        private void έλεγχοςΦώτωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Light light = new Light();
            light.Show();
            this.Hide();
        }
    }
}
