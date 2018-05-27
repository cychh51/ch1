using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 數字翻譯
{
    public partial class Form1 : Form
    {
        public String 數字;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            數字 = Convert.ToString(textBox1.Text);

            switch (數字)
            {
                case "1":
                    textBox2.Text = Convert.ToString("這個英文名叫ONE");break;
                case "壹":
                    textBox2.Text = Convert.ToString("這個英文名也叫做ONE");break;
                case "2":
                    textBox2.Text = "這個英文名叫TWO";break;
                case "貳":
                    textBox2.Text = "這個英文名也叫做TWO";break;
                case "3":
                    textBox2.Text = "這個英文名叫做THREE";break;
                case "叁":
                    textBox2.Text = "這個英文名也叫做THREE";break;                
                default:
                    textBox2.Text = "沒有這個翻譯";break;

            }
           


        }
    }
}
