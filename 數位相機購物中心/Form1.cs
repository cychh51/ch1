using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 數位相機購物中心
{
    public partial class Form1 : Form
    {
        public int 加購;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int 價格;
                      
            String 贈品;

            價格 = ((radioButton1.Checked == true) ? 7980 : (radioButton2.Checked == true) ? 8888 : 5880);
            贈品 = ((radioButton4.Checked == true) ? "清潔組" : (radioButton5.Checked == true) ? "保護貼" : "防潮盒");

           if(checkBox1.Checked == true && checkBox2.Checked==false)
            {
                加購 = 588;
            }
           else if(checkBox1.Checked == false && checkBox2.Checked == true)
            {
                加購 = 390;
            }
           else if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                加購 = 390 + 588;
            }
            else
            {
                加購 = 0;
            }



            label2.Text = "總價為" + (價格) +"SDF"+ (加購) + "加贈" + 贈品.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Font = new Font("標楷體", 26);
        }
    }
}
