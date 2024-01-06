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
    public partial class Shoe3 : Form
    {
        public Shoe3()
        {
            InitializeComponent();
        }
        //take sum for form2
        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = Shoe2.sum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Shoe2.sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shoe4 form4 = new Shoe4();
            form4.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Shoe2 shoe2 = new Shoe2();
            shoe2.Show();
            this.Close();
        }
    }
}
