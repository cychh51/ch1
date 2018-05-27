using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈6
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

            for(int a = 0; a <= 5; a++)
            {
                for( int b = 1; b < a+1; b++)
                {
                    show += b;
                }

                show += '\n';
            }
            

            MessageBox.Show(show);

        }
    }
}
