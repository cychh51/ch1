using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Form1 : Form
    {
        int picture_number = 0;

        DateTime afterTime;



        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer1.Interval = 100;
            label2.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {


            timer1.Enabled = true;
            button2.Enabled = true;
            afterTime = DateTime.Now;




        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            timer1.Enabled = false;
            label2.Text = (DateTime.Now - afterTime).TotalSeconds.ToString();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {



            if(picture_number < 3)
            {

            pictureBox1.Image = imageList1.Images[picture_number];
                picture_number++;

            }

            else
            {

                picture_number = 0;
                //pictureBox1.Image = imageList1.Images[picture_number];
            }


        }

    }
}
