using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 迴圈反三角_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string a = "";

            for(int i  = 0; i <= 5; i++)
            {

                for(int s = 5; s >= i; s--)
                {

                    a += "*";

                }
                a += "\n";

            }

            MessageBox.Show(a);


        }
    }
}
