using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 數字翻譯_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = Convert.ToString(textBox1.Text);

            switch (a)
            {

                case "1": textBox2.Text = "你好"; break;
                        

            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox2.ReadOnly = true;



        }
    }
}
