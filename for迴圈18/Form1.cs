using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string show1 = "*";
            string show2 = " ";
            int s = 4;

            for(int i = 0; i < 5; i++)
            {
                for(int k = 0; k < s; k++)
                {
                    show2 += " ";
                }
                s--;
                for(int j = 0;j <2* i + 1; j++)
                {
                    show1 += "*";
                }
                show1 += '\n';



            }
            MessageBox.Show(show1);
        }
    }
}
