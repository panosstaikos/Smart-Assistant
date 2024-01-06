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
    public partial class Map : Form
    {
        Bitmap gym_car = Properties.Resources.gym_car;
        Bitmap gym_foot = Properties.Resources.gym_foot;
        Bitmap uni_bus = Properties.Resources.uni_bus;
        Bitmap work_car1 = Properties.Resources.work_car1;
        Bitmap work_car2 = Properties.Resources.work_car2;
        Bitmap work_car3 = Properties.Resources.work_car3;
        public Map(int image_code)
        {
            InitializeComponent();
            switch (image_code)
            {
                case 1:
                    pictureBox1.Image = uni_bus;
                    break;
                case 2:
                    pictureBox1.Image = work_car1;
                    break;
            }
        }

       

        private void OkButton_Click(object sender, EventArgs e)
        {
            SmartAssistant sa = new SmartAssistant();
            sa.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == work_car1)
            {
                pictureBox1.Image = work_car2;
            }else if (pictureBox1.Image == work_car2)
            {
                pictureBox1.Image = work_car3;
            }else if (pictureBox1.Image == work_car3)
            {
                pictureBox1.Image = work_car1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == work_car1)
            {
                pictureBox1.Image = work_car3;
            }
            else if (pictureBox1.Image == work_car2)
            {
                pictureBox1.Image = work_car1;
            }
            else if (pictureBox1.Image == work_car3)
            {
                pictureBox1.Image = work_car2;
            }
        }
    }
}
