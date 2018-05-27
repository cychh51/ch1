using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列練習scoravg_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            string 錯誤 = "錯誤";
            int 判斷;
            int 幾位 = 1;
            int n = 0; //紀錄陣列次數
            int t = 0; //紀錄迴圈次數
            int[] 迴圈 = new int[] { 0, 1, 2, 3, 4, 5 };
            int[] 陣列 = new int[5];

        private void Form1_Load(object sender, EventArgs e)
        {




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

            陣列[n] = Convert.ToInt32(textBox1.Text);  
                        
            for( 迴圈[t] = 0; 迴圈[t] <= n; t++)
            {
                richTextBox1.Text += "第" + 幾位  + "位的成績" + textBox1.Text + "\n";

                幾位++;
            }         
            n++;
            textBox1.Text = " ";
            textBox1.Focus();


            if(幾位 == 6)
            {
                button1.Enabled = false;
                textBox1.ReadOnly = true;

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int 結果 = 0;

            foreach (int a in 陣列)
            {

                結果 += a;
            }

            MessageBox.Show((結果 / 2).ToString());

        }
    }
}
