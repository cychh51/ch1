using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 迴圈例題1
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
            

            for(int i =1; i<=6; i++)
            {

                for (int a = 1; a <= i; a++)
                {
                    str += "*";
                }
                str += '\n';
            }
            MessageBox.Show(str);

        }
    }
}
