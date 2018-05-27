using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 尋找質數_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int 輸入 = Convert.ToInt32(textBox1.Text);
            int 條件 = 2;

            string 結果 = "";



            while (條件 < 輸入)
            {

                if (輸入 % 條件 == 0)
                {
                    結果 = "不是質數";
                    break;
                }

                if(輸入 % 條件 != 0)
                {
                    結果 = "是質數";
                    break;
                }


            條件++;

            }

            MessageBox.Show(結果);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
