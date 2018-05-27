using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機5
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




                double number1 = double.Parse(textBox1.Text);
                double number2 = Convert.ToDouble(textBox3.Text);
                string and = textBox2.Text;
                double end = 0.0;

                //MessageBox.Show(textBox1.Text + textBox2.Text + "=");

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

            catch (Exception)
            {
               
                MessageBox.Show("輸入錯誤");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
