using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列練習scoravg_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int 判斷; //給用來判斷輸入是否整數
        string 錯誤 = "錯誤"; 

        int 紀錄 = 0;      //紀錄輸入成績次數
        int[] 輸入的成績 = new int[5];
       

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


            輸入的成績[紀錄] = Convert.ToInt32(textBox1.Text);

            for(int i = 0; i <= 紀錄; i++)
            {             

                for(int a = 0; a == i ; a++)
                {

                    richTextBox1.Text +=  "第" + (紀錄 + 1) + "位成績為" + Convert.ToString(textBox1.Text) + "\n";

                 label1.Text = "請輸入第" + (紀錄 + 2) + "位成績";
                    
                }

                
            }           

           紀錄++; //輸入成績次數+1
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int 總和 = 0;

            for (int g = 0; g < 輸入的成績.Length; g++)
            {

                總和 += 輸入的成績[g] / 2;

            }

            MessageBox.Show(總和.ToString());
            

        }

        private void button2_ClientSizeChanged(object sender, EventArgs e)
        {




        }

    }
}
