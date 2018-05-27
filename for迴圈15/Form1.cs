using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈15
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
            for(int i = 1; i <= 9; i++)
            {
                for(int k= 1; k <= 9; k++)
                {

                    show += i + "x" + k + "=" + (i * k) +",";

                }
                show += '\n';

                
            }
            MessageBox.Show(show);


        }
    }
}
