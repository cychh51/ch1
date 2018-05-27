using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            


                double number1 = Convert.ToDouble(textBox1.Text);
                double number2 = Convert.ToDouble(textBox2.Text);
                string and = comboBox1.Text;
                double end = 0.0;

                switch (and)
                {
                    case "+": end = number1 + number2; break;
                    case "-": end = number1 - number2; break;
                    case "*": end = number1 * number2; break;
                    case "/": end = number1 / number2; break;
                }
                textBox3.Text = end.ToString();
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            string and = comboBox1.Text;
            double end = 0.0;

            switch (and)
            {
                case "+": end = number1 + number2; break;
                case "-": end = number1 - number2; break;
                case "*": end = number1 * number2; break;
                case "/": end = number1 / number2; break;
            }
            textBox3.Text = end.ToString();

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            string and = comboBox1.Text;
            double end = 0.0;

            switch (and)
            {
                case "+": end = number1 + number2; break;
                case "-": end = number1 - number2; break;
                case "*": end = number1 * number2; break;
                case "/": end = number1 / number2; break;
            }
            textBox3.Text = end.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            this.Text = "計算機8";
        }
    }
}
