using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 無法整除3的數字_3
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

            int 條件 = 0;

            string 結果 = "";


            do
            {


                條件++;

                if (條件 % 3 == 0)
                {
                    continue;
                }

                結果 += 條件 + " ";

            }
            while (條件 < 輸入);

            MessageBox.Show(結果);

        }
    }
}
