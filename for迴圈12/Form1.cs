using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            string show = "";

            for (int i  = 0; i <= 5; i++)
            {
                for(int k = 0; k <=i;k++)
                {
                    show += "*";
                }

                show += '\n';
            }

            MessageBox.Show(show);
        }
    }
}
