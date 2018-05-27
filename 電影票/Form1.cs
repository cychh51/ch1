using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電影票
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
            textBox1.MaxLength = 3;
            textBox1.TabIndex = 0;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int 張數 = int.Parse(textBox1.Text);
            int 總金額 = Convert.ToInt32(label5.Text) * Convert.ToInt32(張數);
            textBox2.Text = 總金額.ToString();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
