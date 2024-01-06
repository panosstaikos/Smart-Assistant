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
    public partial class Shoe4 : Form
    {
        public Shoe4()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Shoe2 shoe2 = new Shoe2();
            shoe2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η παραγγελία σας ολοκληρώθηκε!!");
            Shoe2 shoe2 = new Shoe2();
            shoe2.Show();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label6.Text = Shoe2.sum.ToString();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Shoe3 shoe3 = new Shoe3();
            shoe3.Show();
            this.Close();
        }
    }
}
