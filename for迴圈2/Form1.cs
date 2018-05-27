using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            double 結果 = 0.0;

            for(double i = 0.5; i <= 10; i += 0.5)
            {
                結果 += i; 
            }
            MessageBox.Show(Convert.ToString(結果));


        }
    }
}
