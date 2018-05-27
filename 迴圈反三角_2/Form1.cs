using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 迴圈反三角_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          


            string 空白 = "";
            string 結果 = "";


            for (int a = 0; a <= 6; a++)
            {

                for (int g = 6; g >= a; g--)
                {

                    空白 += "1";

                }
                
                for(int i = 0; i < a; i++)
                {

                    空白 += "*";

                }

                空白 += "\n";

            }



            結果 =  空白 ;
            



            MessageBox.Show(結果);

        }
    }
}
