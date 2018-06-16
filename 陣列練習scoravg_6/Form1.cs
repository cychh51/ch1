using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列練習scoravg_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] 輸入成績 = new int[5];
        int 判斷 = 0;
        int 條件 = 0;
        int 輸入判斷;
        int 結果;

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "請輸入成績";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out 輸入判斷) == false)
            {

                MessageBox.Show("請輸入數字");
                textBox1.Focus();
                return;

            }


            輸入成績[判斷] = Convert.ToInt32(textBox1.Text);

            for(int i = 條件; i <= 判斷; i++)
            {

                richTextBox1.Text += "第" + (條件 + 1) + "位成績為" + Convert.ToString(textBox1.Text) + "\n";  
                label1.Text = "請輸入第" + (條件 + 2) + "位成績";
                



            }
            條件++;
            判斷++;
            textBox1.Text = "";
            textBox1.Focus();

            if(條件 == 4)
            {
                    label1.Text = "計算平均";
                    textBox1.Enabled= false;
                    button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            for(int o = 0; o <= 4; o++)
            {

                結果 += 輸入成績[o];

            }

            MessageBox.Show((結果 / 2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            條件 = 0;
            判斷 = 0;
            richTextBox1.Text = "";
            button1.Enabled = true;
            textBox1.Enabled = true;
        }
    }
}
