using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 家庭電表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;
            textBox1.TabIndex = 0;
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int 輸入 = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(輸入 * 2.1) + "元";
                textBox1.Focus();
            }
            catch (Exception ww)
            {
                MessageBox.Show(ww.ToString());
                textBox2.Text = "輸入錯誤".ToString();
                textBox1.Clear();
            }

            


        }
    }
}
