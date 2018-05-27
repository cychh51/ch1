using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 迴圈反三角_6
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

            for(int A = 0; A <= 4; A++)
            {
                for(int o = 4; o >= A; o--)
                {

                    ans += "  ";

                }
                for(int Y = 0; Y <= A; Y++)
                {

                    ans += "*";

                }




                ans += "\n";

            }


            MessageBox.Show(ans);
        }
    }
}
