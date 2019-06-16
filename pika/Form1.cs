using pika.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Sound();
        }

        async void Button1_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(Sound);
            //thread.Start();
            Sound();
            await Task.Delay(4000);

            Cycle();



            pictureBox26.Image = Resources.ash;
            pictureBox26.BringToFront();
            await Task.Delay(2000);
            pictureBox26.Image = null;

            pictureBox25.Image = Resources.source;
            pictureBox25.BringToFront();
            await Task.Delay(2000);
            pictureBox25.Image = null;

            pictureBox26.Image = Resources.ash;
            pictureBox26.BringToFront();
            await Task.Delay(2000);

            pictureBox25.Image = Resources.source;
            pictureBox25.BringToFront();
            await Task.Delay(2000);

            //Cycle();

            pictureBox27.Image = Resources.full_IMG_4632;
            pictureBox27.BringToFront();
            await Task.Delay(2000);
            pictureBox27.Image = null;
            await Task.Delay(2000);

            pictureBox27.Image = Resources._3cafeb5414afb38443ca5ffb94c7aa4a;
            pictureBox27.BringToFront();
            await Task.Delay(2000);
            pictureBox27.Image = null;
            await Task.Delay(2000);

            pictureBox27.Image = Resources._1370449272314;
            pictureBox27.BringToFront();
            await Task.Delay(2000);
            pictureBox27.Image = null;
            await Task.Delay(2000);

            pictureBox27.Image = Resources.s1200;
            pictureBox27.BringToFront();
            await Task.Delay(2000);
            pictureBox27.Image = null;
            await Task.Delay(2000);

            pictureBox27.Image = Resources.pokemon_PNG75;
            pictureBox27.BringToFront();
            await Task.Delay(2000);
            pictureBox27.Image = null;
            await Task.Delay(2000);

            pictureBox28.Image = Resources.mfn8d5sp;
            pictureBox28.BringToFront();
            await Task.Delay(2000);
            //pictureBox28.Image = null;
            //await Task.Delay(2000);

            pictureBox28.Image = Resources._19070;
            pictureBox28.BringToFront();
            await Task.Delay(2000);
            //pictureBox28.Image = null;
            //await Task.Delay(2000);

            pictureBox28.Image = Resources.wW6eBg;
            pictureBox28.BringToFront();
            await Task.Delay(2000);
            //pictureBox28.Image = null;
            //await Task.Delay(2000);


            Cycle();

        }
        async void Sound()
        {
            await Task.Run(() =>
            {
            SoundPlayer simpleSound = new SoundPlayer(Resources.Pokemon_Rus);
            simpleSound.Play();

            });
            
        }

        async void Cycle()
        {
            
            //for(byte b = 20; b > 0; b--)
            //{

            pictureBox1.Image = Resources.pikachu_0;
            pictureBox1.BringToFront();
            await Task.Delay(250);
            pictureBox1.Image = null;

            pictureBox2.Image = Resources.pikachu_1;
            pictureBox2.BringToFront();
            await Task.Delay(250);
            pictureBox2.Image = null;

            pictureBox3.Image = Resources.pikachu_2;
            pictureBox3.BringToFront();
            await Task.Delay(250);
            pictureBox3.Image = null;

            pictureBox4.Image = Resources.pikachu_3;
            pictureBox4.BringToFront();
            await Task.Delay(250);
            pictureBox4.Image = null;

            pictureBox5.Image = Resources.pikachu_4;
            pictureBox5.BringToFront();
            await Task.Delay(250);
            pictureBox5.Image = null;

            pictureBox6.Image = Resources.pikachu_5;
            pictureBox6.BringToFront();
            await Task.Delay(250);
            pictureBox6.Image = null;

            pictureBox7.Image = Resources.pikachu_6;
            pictureBox7.BringToFront();
            await Task.Delay(250);
            pictureBox7.Image = null;

            pictureBox8.Image = Resources.pikachu_7;
            pictureBox8.BringToFront();
            await Task.Delay(250);
            pictureBox8.Image = null;

            pictureBox9.Image = Resources.pikachu_8;
            pictureBox9.BringToFront();
            await Task.Delay(250);
            pictureBox9.Image = null;

            pictureBox10.Image = Resources.pikachu_9;
            pictureBox10.BringToFront();
            await Task.Delay(250);
            pictureBox10.Image = null;

            pictureBox11.Image = Resources.pikachu_10;
            pictureBox11.BringToFront();
            await Task.Delay(250);
            pictureBox11.Image = null;

            pictureBox12.Image = Resources.pikachu_11;
            pictureBox12.BringToFront();
            await Task.Delay(250);
            pictureBox12.Image = null;

            pictureBox13.Image = Resources.pikachu_12;
            pictureBox13.BringToFront();
            await Task.Delay(250);
            pictureBox13.Image = null;

            pictureBox14.Image = Resources.pikachu_13;
            pictureBox14.BringToFront();
            await Task.Delay(250);
            pictureBox14.Image = null;



                pictureBox15.Image = Resources.pikachu_0;
                pictureBox15.BringToFront();
                await Task.Delay(250);
                pictureBox15.Image = null;

                pictureBox16.Image = Resources.pikachu_1;
                pictureBox16.BringToFront();
                await Task.Delay(250);
                pictureBox16.Image = null;

                pictureBox17.Image = Resources.pikachu_2;
                pictureBox17.BringToFront();
                await Task.Delay(250);
                pictureBox17.Image = null;

                pictureBox18.Image = Resources.pikachu_3;
                pictureBox18.BringToFront();
                await Task.Delay(250);
                pictureBox18.Image = null;

                pictureBox19.Image = Resources.pikachu_4;
                pictureBox19.BringToFront();
                await Task.Delay(250);
                pictureBox19.Image = null;

                pictureBox20.Image = Resources.pikachu_5;
                pictureBox20.BringToFront();
                await Task.Delay(250);
                pictureBox20.Image = null;

                pictureBox21.Image = Resources.pikachu_6;
                pictureBox21.BringToFront();
                await Task.Delay(250);
                pictureBox21.Image = null;

                pictureBox22.Image = Resources.pikachu_7;
                pictureBox22.BringToFront();
                await Task.Delay(250);
                pictureBox22.Image = null;

                pictureBox23.Image = Resources.pikachu_8;
                pictureBox23.BringToFront();
                await Task.Delay(250);
                pictureBox23.Image = null;

                pictureBox24.Image = Resources.pikachu_9;
                pictureBox24.BringToFront();
                await Task.Delay(250);
                pictureBox24.Image = null;

            //}

        }
    }
}
