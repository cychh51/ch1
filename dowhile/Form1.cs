using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dowhile
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
            string 答案 = "";


            do
            {
                數字++;

                if (數字 % 3 == 0)
                {
                    continue;
                }

                答案 += 數字.ToString() + " ";

            }
            while (數字 <= 20);

            MessageBox.Show(答案);

        }
    }
}
