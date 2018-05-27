using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 迴圈反三角_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string 答案 = "";



            for(int i = 0; i <= 4; i++)
            {

            for(int a = 4; a >= i; a--)
                {


                    答案 += "  ";


                }

                for(int r = 0; r <= i; r++)
                {

                答案 += "*";

                }


               

                答案 += "\n";


            }



            MessageBox.Show(答案);
        }
    }
}
