using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 整除正整數
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
                int 輸入 = Convert.ToInt32(textBox1.Text);
                int 結果2 = 0;
                string 結果 = 輸入 + "能夠整除7的數字" + "\n";
                string 錯誤 = "輸入錯誤";
                string 答案 = "";
                


                if (輸入 >= 7 && 輸入 <= 100)
                {

                    for (int a = 7; a <= 輸入; a += 7)
                    {

                        結果 += a + "\n";
                        結果2 += a;
                    }

                    答案 = 結果 + ("------------" + "\n" + "總和等於" + 結果2.ToString());

                }
                else
                {
                    MessageBox.Show(錯誤);                
                }


                MessageBox.Show(答案);
            }
            catch
            {
                string 錯誤2 = "請輸入數字";
                MessageBox.Show(錯誤2);
            }
        }
    }
}
