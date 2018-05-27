using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 無法整除4的數字_5
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

            int i = 0;

            int 條件 = 0;

            string 結果 = "";

            i = Convert.ToInt32(textBox1.Text);

            do
            {

                條件++;

                if (i % 條件 == 0)
                {

                    continue;

                }

                結果 += 條件 + " ";

            }

            while (條件 < i);

            MessageBox.Show(結果);

        }
    }
}
