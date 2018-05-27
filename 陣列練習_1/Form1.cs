using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 陣列練習_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int[] a = new int[] { 50, 40, 70, 80, 30 };

            int b = 0;

            string c = "";

            for(int i = 0;  i < a.Length; i++)
            {


                c += a[i] + " ";
                

            }

            


            MessageBox.Show(c);


        }
    }
}
