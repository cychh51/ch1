using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @break
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int y = 7;
            int x = 2;
            string show = y +"是質數";

            while (x < y)
            {

                if (y % x == 0)
                {
                    show = y + "不是質數";
                    break;

                }
                
                x++;

            }

            MessageBox.Show(show);




        }
    }
}
