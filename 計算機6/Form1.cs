using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機6
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


                double number1;
                double number2;
                double end = 0;
                string and = comboBox1.Text;

                number1 = Convert.ToDouble(textBox1.Text);
                number2 = double.Parse(textBox2.Text);
                //and = comboBox1.Text;

                switch (and)
                {

                    case "+": end = number1 + number2; break;
                    case "-": end = number1 - number2; break;
                    case "*": end = number1 * number2; break;
                    case "/": end = number1 / number2; break;                 


                }
                textBox3.Text = end.ToString();

            }
            catch
            {
                MessageBox.Show("輸入錯誤","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
