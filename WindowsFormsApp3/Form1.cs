using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

            int i, a;

            for ( i = 1; i <= 5; i++)
            {


                for( a = 1; a <= i; a++)
                {

                    show += "*";
                    

                }

              


                show += '\n';
            }


            for( i = 1; i <= 5; i++)
            {


               for(a = 1; a <= 5-i; a++)
                {

                    show += "*";

                }

                
              

                
                

                   show += '\n';
            }

            MessageBox.Show(show);
        }
    }
}
