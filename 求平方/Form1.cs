using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 求平方
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            int 數字 = 0;
            string 結果 = "";

            do
            {
                數字++;

                if (數字 % 3 == 0)
                {
                    continue;

                }

                結果 += 數字 + " ";
            }

            while (數字 <= 20);


            MessageBox.Show(結果);
        }
    }
}
