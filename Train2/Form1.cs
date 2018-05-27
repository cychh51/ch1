using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train2
{
    public partial class Form1 : Form
    {
        public int 公里數;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            公里數 = Convert.ToInt32(textBox1.Text);

            double 票價 = 0;
            double 金額 = 0;
            

            票價 = checkBox1.Checked == true ? 2.27 : (checkBox2.Checked == true ? 1.75 : 1.46);

            金額 = Convert.ToInt32( 票價 * 公里數);

            if (radioButton1.Checked == true)
            {
                金額 = 金額 * 1;
                
               
            }
            if (radioButton2.Checked == true)
            {
                金額 =Convert.ToInt32( 金額 / 2);
            }
            if(radioButton3.Checked == true)
            {
                金額 = Convert.ToInt32(金額 / 1.5);
            }
            if(radioButton4.Checked == true)
            {
                金額 = Convert.ToInt32(金額 / 1.2);
            }
            if(radioButton4.Checked == true)
            {
                金額 = Convert.ToInt32((金額 * 2) / 8);
            }

            label1.Text = 金額.ToString();
        }
    }
}
