using System;
using System.Windows.Forms;

namespace 迴圈反三角
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

            int i , a , j;

            string sum = "";

           

            for (i = 1; i <= 6; i++)
            {


                for(j = 1; j <= 6-i; j++)
                {

                    sum += "  ";
                    

                }


                for (a = 1; a <= i; a++)
                {

                    sum += "*";

                }

              


               sum += '\n';

            }

            MessageBox.Show(sum);

        }
    }
}
