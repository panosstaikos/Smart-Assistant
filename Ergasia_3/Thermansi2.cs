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
    public partial class Thermansi2 : Form
    {
        public Thermansi2()
        {
            InitializeComponent();
        }
        //temperature regulation
        private void button1_Click(object sender, EventArgs e)
        {
            Thermansi1 form1 = new Thermansi1();
            form1.Show();
            this.Close();
        }
    }
}
