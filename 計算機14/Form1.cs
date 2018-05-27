using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double number1 = 0.0;
            double number2 = 0.0;
            string and = textBox2.Text;
            double end = 0.0;
            try
            {



                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox3.Text);



                switch (and)
                {
                    case "+": end = Convert.ToDouble(number1 + number2); break;
                    case "-": end = Convert.ToDouble(number1 - number2); break;
                    case "*": end = Convert.ToDouble(number1 * number2); break;
                    case "/": end = Convert.ToDouble(number1 / number2); break;

                }

                label1.Text = end.ToString();
            }
            catch
            {
                MessageBox.Show("錯誤");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
