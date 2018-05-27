using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機3
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
            try
            {


                double number1 = Double.Parse(textBox1.Text);
                double number2 = Double.Parse(textBox2.Text);
                double end;
                string and = comboBox1.Text;

                switch (and)
                {
                    case "+": end = number1 + number2; break;
                    case "-": end = number1 - number2; break;
                    case "*": end = number1 * number2; break;
                    case "/": end = number1 / number2; break;
                    default: throw new Exception("輸入錯誤");

                }

                textBox3.Text = end.ToString();
            }
            catch(Exception ww)
            {
                MessageBox.Show(ww.ToString());
            }
            

        }
    }
}
