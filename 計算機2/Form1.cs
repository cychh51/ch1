using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機2
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

                double number1, number2;
                double end = 0.0;
                string and;
                number1 = Double.Parse(textBox1.Text);
                number2 = Double.Parse(textBox2.Text);
                and = comboBox1.Text;
                //MessageBox.Show(number1 + and + number2 + "=");
                switch (and)
                {
                    case "+": end = (number1 + number2); break;
                    case "-": end = (number1 - number2); break;
                    case "*": end = (number1 * number2); break;
                    case "/": end = (number1 / number2); break;
                    default: throw new Exception("計算符號錯誤");
                }

                textBox3.Text = end.ToString();

            }
            catch (Exception)
            {

                string 輸入錯誤 = "輸入錯誤";

                MessageBox.Show(輸入錯誤.ToString());

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
