using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機9
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


                double number1 = Convert.ToDouble(textBox3.Text);
                double number2 = Convert.ToDouble(textBox1.Text);
                string and = textBox2.Text;
                double end = 0;

                switch (and)
                {
                    case "+": end = number1 + number2; break;
                    case "-": end = number1 - number2; break;
                    case "*": end = number1 * number2; break;
                    case "/": end = number1 / number2; break;

                }
                textBox4.Text = end.ToString();

            }
            catch
            {
                MessageBox.Show("輸入錯誤");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
        }
    }
}
