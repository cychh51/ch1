using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈16
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


            for(int i = 0; i <= 5; i++)
            {
                for (int k = 1; k <= i+1; k++)
                {
                    for (int j = 0; j < 2 * k; j++)
                    {
                        show += "*";
                    }
                    
                }
                show += '\n';
            }
            MessageBox.Show(show);

        }
    }
}
