using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機11
{
    public partial class Form1 : Form
    {


        public double number1;
        public double number2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                number2 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }


            switch (textBox2.Text)
            {
                case "+":
                    textBox4.Text = Convert.ToString(number1 + number2);break;
                case "-":
                    textBox4.Text = Convert.ToString(number1 - number2);break;
                case "*":
                    textBox4.Text = Convert.ToString(number1 * number2);break;
                case "/":
                    if(number1 != 0)
                    {
                        textBox4.Text = Convert.ToString(number1 / number2);
                    }
                    else
                    {
                        textBox4.Text = "除數不可為0";
                    }break;

                

                    

            }
            


        }
    }
}
