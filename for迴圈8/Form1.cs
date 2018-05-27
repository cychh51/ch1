using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for迴圈8
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

            for(int x = 0; x<=5; x++)
            {

                for (int y = 0; y <= x; y++)
                {
                    show += "*";
                    
                }
                show += '\n';
                



            }

            MessageBox.Show(show);

        }
    }
}
