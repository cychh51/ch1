using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈14
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
            

            for (int i = 0; i <= 5; i++)
            {
                for(int k = 5; k >= i; k-=1)
                {
                    show += "*";
                }
                show += '\n';

            }
            MessageBox.Show(show);

        }
    }
}
