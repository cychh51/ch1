using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜數字2
{
    public partial class Form1 : Form
    {

        public int 輸入;
        public int 解答 = 50;
        public int 點擊次數;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            點擊次數 += 1;
            輸入 = Convert.ToInt32(textBox1.Text);

            if(輸入== 解答)
            {
                label1.Text = "恭喜答對";
            }
            else if (輸入 < 解答)
            {
                label1.Text = "太小";
            }
            else if (輸入 > 解答)
            {
                label1.Text = "太大";
            }

            label2.Text = 點擊次數.ToString();

        }
    }
}
