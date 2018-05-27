using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forcjo6mf0
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

            for(int i = 1 ; i <= 3 ; i++)
            {
                for(int j = 1 ; j <= 3 ; j++)
                {

                    show += "*";

                }

                show += '\n';

            }
            MessageBox.Show(show);


        }
    }
}
