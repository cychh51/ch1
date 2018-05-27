using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fsdfsdfdsf
{
    public partial class Form1 : Form
    {

        public int 輸入;
        public string 答案;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            radioButton1.Checked = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            輸入 = Convert.ToInt32(textBox1.Text);         


            if(radioButton1.Checked == true)
            {
               答案 = Convert.ToString("標準體重:" + (輸入-80)*0.7);
                label2.Text = 答案.ToString();
            }
             if(radioButton2.Checked == true)
            {
                答案 = Convert.ToString("標準體重:" + (輸入 - 70) * 0.6);
                label2.Text = 答案.ToString();
            }


        }
    }
}
