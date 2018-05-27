using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 匯率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            int 輸入金額 = Convert.ToInt32(textBox1.Text);
            double 匯率 = Convert.ToDouble(textBox2.Text);


            if (radioButton1.Checked == true)
            {
                label3.Text = ("台幣" + Convert.ToInt32(輸入金額) + "可兌換美金" + (Convert.ToDouble (輸入金額 * 匯率).ToString("F2")) + "元").ToString();

            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


            int 輸入金額 = Convert.ToInt32(textBox1.Text);
            double 匯率 = Convert.ToDouble(textBox2.Text);


            if (radioButton2.Checked == true)
            {
                label3.Text = ("美金" + Convert.ToInt32(輸入金額) + "可兌換台幣" + (Convert.ToDouble(輸入金額 / 匯率).ToString("F2"))+"元").ToString();
            }


        }



    }
}
