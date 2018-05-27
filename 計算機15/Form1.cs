using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機15
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



                string 錯誤 = "錯誤";
                string 運算 = Convert.ToString(textBox2.Text);
                double A = Convert.ToDouble(textBox1.Text);
                double B = Convert.ToDouble(textBox3.Text);
                double 結果 = 0.0F;






                switch (運算)
                {
                    case "+": 結果 = (A + B); break;

                    case "-": 結果 = (A - B); break;

                    case "*": 結果 = (A * B); break;

                    case "/": 結果 = (A / B); break;

                    default: throw new Exception(textBox3.Text = 錯誤);
                }

                textBox4.Text = 結果.ToString();
            }

            catch
            {

                MessageBox.Show("錯誤");
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
