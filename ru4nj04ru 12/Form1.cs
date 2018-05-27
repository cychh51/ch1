using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ru4nj04ru_12
{
    public partial class Form1 : Form
    {

        public double number1;
        public double number2;
        public string 運算子;
        public double 解答;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            運算子 = Convert.ToString(textBox2.Text);
            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox3.Text);

            switch (運算子)
            {

                case "+":
                    解答 = Convert.ToDouble(number1 + number2);break;
                case "-":
                    解答 = Convert.ToDouble(number1 - number2);break;
                case "*":
                    解答 = Convert.ToDouble(number1 * number2);break;
                case "/":
                    解答 = Convert.ToDouble(number1 / number2);break;
                default:
                    MessageBox.Show("輸入錯誤");break;

            }

            textBox4.Text = 解答.ToString();

            


        }
    }
}
