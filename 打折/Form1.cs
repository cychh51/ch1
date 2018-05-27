using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打折
{
    

    public partial class Form1 : Form
    {
        public int 購買金額;
        public double 實付金額;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            購買金額 = Convert.ToInt32(textBox1.Text);

            if (購買金額 >= 1000)
            {
                實付金額 = 1000 + Convert.ToDouble(購買金額 - 1000) * 0.8;
            }
            textBox2.Text = 實付金額.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
