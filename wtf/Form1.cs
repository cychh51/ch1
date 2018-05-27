using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wtf
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }    

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;


            /*double 年利率 = 0.04;*/
            double 年數 = 20;
            /*textBox2.Text = (年利率*100).ToString();*/
            textBox3.Text = 年數.ToString();         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int 借款 = Convert.ToInt32(textBox1.Text);
            double 年利率 = Convert.ToDouble(textBox2.Text);
            double 年數 = 20;
            double 應還本息 = (Math.Pow((1 + 年利率 / 12), 年數 * 12) * 年利率 / 12) / (Math.Pow((1 + 年利率 / 12), 年數 * 12) - 1);          
            textBox4.Text = (應還本息 * 借款+0.5).ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int 借款 = Convert.ToInt32(textBox1.Text);
            double 年利率 = Convert.ToDouble(textBox2.Text);
            double 年數 = 20;
            double 應還本息 = (Math.Pow((1 + 年利率 / 12), 年數 * 12) * 年利率 / 12) / (Math.Pow((1 + 年利率 / 12), 年數 * 12) - 1);
            textBox4.Text = (應還本息 * 借款 + 0.5).ToString();
        }
    }
}
