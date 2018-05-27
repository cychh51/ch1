using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 1; i <= 5; i++)
            {

               for(int w = 1; w == i; w++)
                {
                    str += "1";
                }
                
               for(int g = 2; g == i; g++)
                {
                    str += "1" + "2";
                }

               for(int f = 3; f==i; f++)
                {
                    str += "1" + "2" + "3";
                }

               for(int l = 4; l==i; l++)
                {
                    str += "1" + "2" + "3" + "4";
                }

               for(int b = 5; b==i; b++)
                {
                    str += "1" + "2" + "3" + "4" + "5";
                }
                    str += '\n';
            }


            

            MessageBox.Show(str);

       
        }
    }
}
