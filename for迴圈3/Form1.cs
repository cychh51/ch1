using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            double 結果1 = 0.0;
            double 結果2 = 0.0;

            for (int sum1=1,sum2 = 10;sum1<=10&&sum2>=1;sum1++,sum2-=1)
            {

                結果1 += sum1;
                結果2 += sum2;

            }
            MessageBox.Show(Convert.ToString(結果1 + ","+結果2));

        }
    }
}
