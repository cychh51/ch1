using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 無法整除4的數字_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int 輸入數字 = Convert.ToInt32(textBox1.Text);
            int 答案 = 0; //0~輸入之間無法整除4的數字


            string 結果 = "";

            do
            {

                答案++;

                if (答案 % 4 == 0)
                {

                    continue; //馬上跳至迴圈判斷

                }

                結果 += 答案 + " ";

            }
            while (答案 < 輸入數字);


            MessageBox.Show(結果);

        }
    }
}
