using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列練習scoravg_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int n = 0;
        int[] 陣列 = new int[5];

        string 錯誤 = "輸入錯誤";

        int ans = 0;

        int nub1; //給判斷輸入是不是整數

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out nub1) == false)
            {
                MessageBox.Show(錯誤);
                textBox1.Text = " ";
                textBox1.Focus();
                return;
            }
         
            

            陣列[n] = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i <= n; i++)
            {

                for (int j = 0; j == i; j++)
                {
                    richTextBox1.Text += "第" + Convert.ToInt32(n + 1) + "位成績:" + Convert.ToInt32(textBox1.Text) + "\n";
                    label1.Text = "請輸入第" + Convert.ToInt32(n + 2) + "位成績";
                }
            }

            n++;
            textBox1.Text = " ";
            textBox1.Focus();


            if(n == 5)
            {
                textBox1.ReadOnly = true;
                label1.Text = "請計算平均";
                button1.Enabled = false;
                button2.Enabled = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {


            foreach(int i in 陣列)
            {

                ans += i;

            }

            ans = ans / 2;

            MessageBox.Show(ans.ToString());

        }
    }
}
