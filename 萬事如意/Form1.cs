using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 萬事如意
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("新細明體",60,FontStyle.Bold);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("新細明體", 60, FontStyle.Italic);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("新細明體", 60, FontStyle.Bold | FontStyle.Italic);
        }
    }
}
