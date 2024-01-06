using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia_3
{
    public partial class Pet : Form
    {
        Bitmap food_empty = Properties.Resources.food_empty;
        Bitmap food_fool = Properties.Resources.food_fool;
        Random rnd = new Random();

        //Thread για την αναμονή οσο τρώει ο σκύλος
        private void btnShowWait_Click(object sender, EventArgs e)
        {
            new WaitForm(() => /*Simulate long task*/ Thread.Sleep(5000)).ShowDialog();
        }


        //Ο timer3 χρησιμοποιείται για για τις ακαθαρσίες του σκύλου
        public Pet()
        {
            InitializeComponent();
            timer3.Enabled = true;
        }

        //Αν πατηθεί το κουμπί για το τάισμα του σκύλου, ο timer3 γίνεται false για να μην χτυπάνε μεταξύ τους οι timers
        //έπειτα ελέγχεται αν ο σκύλος έχει φάει ήδη βασει του text του κουμπιού
        //αν δεν έχει φάει ο σκύλος τότε ενεργοποιείται ο timer1 και "γεμίζει το φαγητό του"
        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            if (button2.Text == "Τάισε τον σκύλο")
            {
                if (timer1.Enabled == false)
                {
                    bowl.Image = food_fool;
                    timer1.Enabled = true;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Δεν μπορείτε να ταισετε προς το παρον τον σκυλο, εχει φαει");
            }
        }

        //Ο timer1 χρησιμοποείται για την "κίνηση" του σκύλου προς τη ταιστρα
        //Αρχικά γεμίζει το μπόλ του και γίνονται visible-unvisible τα κατάλληλα picturebox ώστε να φαίνεται οτι περπατάει προς την ταιστρα
        //τέλος επιλέγεται τυχαία το πόσο θα φάει και εμφανίζεται κατάλληλο μήνυμα
        private void timer1_Tick(object sender, EventArgs e)
        {
            bowl.Image = food_fool;
            if (pictureBox1.Visible == true)
            {
                bowl.Image = food_fool;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }else if(pictureBox2.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
            }else if(pictureBox3.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                timer1.Enabled = false;
                btnShowWait_Click(sender, e);//αναμονή για να φάει ο σκύλος
                bowl.Image = food_empty;
                button2.Text = "Οχι αλλο φαι";
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
                timer1.Enabled = false;
                int random_number = rnd.Next(1, 4);
                timer2.Enabled = true;
                switch (random_number)
                {
                    case 1:
                        MessageBox.Show("Ο σκύλος έφαγε λίγο");
                        timer2.Interval = 3000;
                        break;
                    case 2:
                        MessageBox.Show("Ο σκύλος έφαγε μέτρια ποσότητα");
                        timer2.Interval = 6000;
                        break;
                    case 3:
                        MessageBox.Show("ο σκύλος έφαγε πάρα πολύ");
                        timer2.Interval = 10000;
                        break;
                }
                timer3.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button2.Text = "Τάισε τον σκύλο";
            timer2.Enabled = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == false & timer2.Enabled == false & timer1.Enabled == false)
            {
                pictureBox5.Visible = true;
                MessageBox.Show("Ουπς! Ο σκύλος έκανε ακαθαρσίες. Πατήστε πάνω τους για να τις καθαρίσετε");
                timer3.Enabled = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            timer3.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
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
