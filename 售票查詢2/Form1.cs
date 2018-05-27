using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 售票查詢2
{

    


    public partial class Form1 : Form
    {
        public int 身高;
        public int 點擊次數;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                身高 = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                textBox2.Text = "請輸入數字";
                return;
            }
            點擊次數 += 1;
            label2.Text = 點擊次數.ToString();

        if (身高 > 150)
            {
                textBox2.Text = "購買成人票";
            }

        else if(身高 > 110)
            {
                textBox2.Text = "購買兒童票";
            }
        else if (身高 < 110)
            {
                textBox2.Text = "不須買票";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }
    }
}
