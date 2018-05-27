using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈17
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
            for(int k = 0; k <= 5 ; k++)
            {
                for(int i = 1; i <= k ;i++)
                {
                    show += i;
                }
                show += '\n';
            }

            MessageBox.Show(show);

        }
    }
}
