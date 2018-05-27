using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while迴圈2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            int 輸入1 = 5;
            int 輸入2 = 2;


            string show = 輸入1 + "是質數";



            while (輸入2 < 輸入1)
            {

                if (輸入1 % 輸入2 == 0)
                {


                    show = 輸入1 + "不是質數";
                    break;


                }
                else
                {
                    輸入2++;
                }

            }


            MessageBox.Show(show);

        }
    }
}
