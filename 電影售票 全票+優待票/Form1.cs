using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電影售票_全票_優待票
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            
        }

       public void textBox1_TextChanged(object sender, EventArgs e)
        {
            int 張數1 = Convert.ToInt32(textBox1.Text);
            int 金額1 = Convert.ToInt32(label6.Text) * 張數1;         
            textBox3.Text = 金額1.ToString();
            int 總金額 = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text);
            textBox5.Text = 總金額.ToString();
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            

            int 張數2 = int.Parse(textBox2.Text);
            int 金額2 = int.Parse(label7.Text) * 張數2;
            textBox4.Text = 金額2.ToString();
            int 總金額 = Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text);
            textBox5.Text = 總金額.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
                
        }
    }
}
