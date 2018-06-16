using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 無法整除4的數字_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int 輸入 = Convert.ToInt32(textBox1.Text);
            int 判斷 = 0;
            string ans = "";



        while(判斷 < 輸入)
            {

                判斷++;

                if (判斷 % 4 == 0)
                {
                    continue;
                }

             if(判斷 == 輸入)
                {
                    break;
                }

             ans += 判斷 + "  ";

            }

            MessageBox.Show(ans);

        }
    }
}
