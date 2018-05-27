using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈三角
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            string 結果 = "";

            int i, q, k;

            for( i = 1; i <= 6; i++)
            {



                for( q = 1; q <= 6 - i; q++)
                {


                    結果 += "  ";
                  

                }

                for( k = 1; k < i; k++)
                {


                    結果 += "*";
                   

                }





                結果 += "\n";
                
                

                 
                



            }

            

            MessageBox.Show(結果);
        }
    }
}
