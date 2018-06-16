using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 六六乘法表2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string 結果 = "";

            for(int i = 1; i <= 1; i++)
            {

                for (int a = 1; a <= 9; a++ )
                {


                    結果 += i + "x" + a + "=" + (a * i) + ",";

                }

                    結果 += "\n";


            }

            MessageBox.Show(結果);
        }
    }
}
