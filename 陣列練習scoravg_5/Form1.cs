using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列練習scoravg_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int 紀錄 = 0;
        int 迴圈紀錄 = 0;
        int 判斷;
        int[] 輸入成績 = new int[5];
        int 結果 = 0;

        string 錯誤 = "錯誤";

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "請輸入第1位成績";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(int.TryParse(textBox1.Text, out 判斷) == false)
            {
                MessageBox.Show(錯誤);
                textBox1.Text = " ";
                textBox1.Focus();
                return; 
            }

            輸入成績[紀錄] = Convert.ToInt32(textBox1.Text);

            for(int a = 迴圈紀錄; a <= 紀錄; a++)
            {
                richTextBox1.Text += "第" + (紀錄 + 1) + "位成績" + 輸入成績[紀錄] + "\n";
                label1.Text = "請輸入第" + (紀錄 + 2) + "位成績";
                textBox1.Text = " ";
                textBox1.Focus();
            }

            迴圈紀錄++;
            紀錄++;

            if(紀錄 == 5)
            {
                label1.Text = "計算平均";
                button1.Enabled = false;
                textBox1.ReadOnly = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            for(int f = 0; f < 輸入成績.Length; f++)
            {

                結果 += 輸入成績[f] / 2;


            }

            MessageBox.Show(結果.ToString());
        }
    }
}
