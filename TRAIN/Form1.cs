using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAIN
{
    public partial class Form1 : Form
    {

        public int 公里數;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            公里數 = Convert.ToInt32(textBox1.Text);
            double 票價 = 0;


            if(radioButton1.Checked == true)
            {
                票價 = Convert.ToInt32( 公里數 * 2.27);
            }
            if(radioButton2.Checked == true)
            {
                票價 =Convert.ToInt32( 公里數 * 1.75);
            }
            if (radioButton3.Checked == true)
            {
                票價 = Convert.ToInt32( 公里數 * 1.46); 
            }
            if(checkBox1.Checked == true)
            {
                票價 = Convert.ToInt32( 票價 / 2);
            }
            if(checkBox2.Checked == true)
            {
                票價 = Convert.ToInt32( ((票價 * 2) * 0.9));
            }
            label1.Text = 票價.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            radioButton1.Checked = true;
        }
    }
}
