using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 稅金4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int 收入 = Convert.ToInt32(textBox1.Text);
            double 稅金;

            if (收入 < 300000)
            {
                稅金 = 收入;
                label1.Text = Convert.ToString(稅金);
            }
            if (收入 >= 300000 || 收入 < 600000)
            {
                稅金 =Convert.ToDouble (收入 * 0.03);
                label1.Text = 稅金.ToString();
            }

            if (收入 >= 600000 || 收入 < 900000)
            {
                稅金 = Convert.ToDouble(收入 * 0.06);
                label1.Text = 稅金.ToString();
            }
            if (收入 >= 900000 || 收入 < 1500000)
            {
                稅金 = (收入 * 0.12);
                label1.Text = 稅金.ToString();
            }
            if (收入 >= 1500000 || 收入 < 5000000)
            {
                稅金 = (收入 * 0.2);
                label1.Text = 稅金.ToString();
            }
            if(收入>500000)
            {
                稅金 = (收入 * 0.3);
                label1.Text = 稅金.ToString();
            }

        }
    }
}
