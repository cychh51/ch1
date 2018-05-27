using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 稅金
{
    public partial class Form1 : Form
    {


        public int 收入;
        public double 稅率;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            收入 = Convert.ToInt32(textBox1.Text);

            if (收入 <= 100)
            {
                label2.Text =Convert.ToString (0.15);
                稅率 = 0.15;
            }
            else if (收入 < 300)
            {
                label2.Text = Convert.ToString(0.2);
                稅率 = 0.2;
            }
            else if (收入 >= 300)
            {
                label2.Text = Convert.ToString(0.4*100+"%");
                稅率 = 0.4;
            }

            label3.Text = Convert.ToString(稅率 * 收入 * 10000);
        }
    }
}
