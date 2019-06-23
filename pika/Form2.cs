using pika.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace pika
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        void Global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }


        void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            toolTip1.SetToolTip(pictureBox1, "Эш Кетчум - тренер покемонов \nВозраст: ?? лет.");
                      
        }

        void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            toolTip1.SetToolTip(pictureBox2, "Мисти - подруга Эша Кетчума, \nтренер покемонов \nВозраст: ?? лет.");
        }

        private void PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            toolTip1.SetToolTip(pictureBox3, "Брок - друг Эша Кетчума, \nтренер покемонов \nВозраст: ?? лет.");
        }

        private void PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox20_MouseEnter(object sender, EventArgs e)
        {
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox22_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox23_MouseEnter(object sender, EventArgs e)
        {
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PictureBox24_MouseEnter(object sender, EventArgs e)
        {
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void PictureBox24_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
