using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double number1 = Convert.ToDouble(textBox1.Text);
                double number2 = Convert.ToDouble(textBox3.Text);
                double end = 0.0;
                string and = textBox2.Text;
                //MessageBox.Show(number1.ToString() + and + number2.ToString() +"=");
                switch (and)
                {

                    case "+": end = number1 + number2; break;
                    case "-": end = number1 - number2; break;
                    case "*": end = number1 * number2; break;
                    case "/": end = number1 / number2; break;
                    default: throw new Exception("輸入錯誤");

                }
                textBox4.Text = end.ToString();
            }
            catch(Exception ww)
            {             
                MessageBox.Show(ww.ToString());
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }
    }
}
