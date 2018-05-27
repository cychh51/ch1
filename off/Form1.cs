using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace off
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int buy = Convert.ToInt32(textBox1.Text);
            double pay = 0;
            
            if (buy > 1000)
            {
                pay = 1000+Convert.ToInt32(buy - 1000) * 0.9;
            }

            if (buy < 1000)
            {
                pay = Convert.ToInt32(buy * 0.95);
            }
            textBox2.Text = pay.ToString("C0");
        }
    }
}
