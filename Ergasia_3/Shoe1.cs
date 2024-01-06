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
    public partial class Shoe1 : Form
    {
        public Shoe1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        Bitmap papoutsia_douleias = Properties.Resources.papoutsia_douleias;
        Bitmap papoutsia_treximo = Properties.Resources.papoutsia_treximo;
        Bitmap papoutsia_football = Properties.Resources.papoutsia_football;
        Bitmap papoutsia_allstar = Properties.Resources.papoutsia_allstar;
        Bitmap papoutsia_gamos = Properties.Resources.papoutsia_gamos;
        //close form
        private void button1_Click(object sender, EventArgs e)
        {
            Shoe2 form2 = new Shoe2();
            form2.Show();
            this.Hide();
        }
        //epilogh papoutsion gia thn katallhlh douleia
        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                label3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox4.Image = papoutsia_douleias;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                label3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox4.Image = papoutsia_allstar;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox4.Image = papoutsia_football;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox4.Image = papoutsia_treximo;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox4.Image = papoutsia_gamos;
            }
            else
            {
                MessageBox.Show("Δεν υπάρχουν διαθέσιμα παπούτσια για την συγεκριμένη ασχολία σας. Μεταβείτε στο e-shop για να αγοράσετε καινούργιο ζευγάρι για την γκαρνταρόμπα σας!");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            HouseForm houseForm = new HouseForm();
            houseForm.Show();
            this.Close();
        }

        private void έλεγχοςΘέρμανσηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thermansi1 thermansi1 = new Thermansi1();
            thermansi1.Show();
            this.Close();
        }

        private void έλεγχοςΦώτωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Light light = new Light();
            light.Show();
            this.Close();
        }

        private void έξυπνηΠαπουτσοθήκηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shoe1 shoe1 = new Shoe1();
            shoe1.Show();
            this.Close();
        }

        private void δημιουργίαΠλάνουΗμέραςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartAssistant smartAssistant = new SmartAssistant();
            smartAssistant.Show();
            this.Close();
        }

        private void αυτόματηΤαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet();
            pet.Show();
            this.Close();
        }
    }
}
