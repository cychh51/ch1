using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 迴圈反三角_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string ans = "";

            for(int a = 0; a <= 4; a++)
            {

                for(int o = 5; o >= a; o--)
                {

                    ans += "  ";

                }
                for(int s = 0; s <= a; s++)
                {
                    ans += "*";

                }
      
                ans += "\n";

            }





            MessageBox.Show(ans);

        }
    }
}
