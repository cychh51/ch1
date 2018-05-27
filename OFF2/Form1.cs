using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int buy = Convert.ToInt32(textBox1.Text);
            double pay = 0;
            if (buy > 1500)
            {
                pay = 1500 + Convert.ToInt32(buy - 1500) * 0.8;
            }
            textBox2.Text = pay.ToString("C0");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }
    }
}
