using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 稅金2
{


    public partial class Form1 : Form
    {

        public double 收入;
        public double 稅率;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            收入 = Convert.ToDouble(textBox1.Text);
            稅率 = (收入 < 100 ? 0.15 : (收入 > 300 ? 0.4 : 0.2));
            label2.Text = Convert.ToString(稅率 * 100);
            label3.Text = Convert.ToString((收入 * 10000) * 稅率);
        }
    }
}
