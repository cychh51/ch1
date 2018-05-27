using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = 0.0;
            double number2 = 0.0;
            double end = 0.0;
            string and = comboBox1.Text;

            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox3.Text);


            switch (and)
            {

                case "+":end = Convert.ToDouble(number1 + number2);break;
                case "-":end = Convert.ToDouble(number1 - number2);break;
                case "*":end = Convert.ToDouble(number1 * number2);break;
                case "/":end = Convert.ToDouble(number1 / number2);break;

            }
            textBox2.Text = end.ToString();


        }
    }
}
