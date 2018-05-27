using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜數字
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        int ans, asd;

        public void Form1_Load(object sender, EventArgs e)
        {
            
            ans = 50;
            label1.Text = "請輸入1-100之間的數字";
            label3.Text = "共猜了0次";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            asd += 1;
            int guess = Convert.ToInt32(textBox1.Text);
            label3.Text = "共猜了"+asd.ToString()+"次";

            if(guess == ans)
            {
                label1.Text = "答對了";
                
            }
            else if (guess < ans)
            {
                label1.Text = "太小了請重猜。" ;
                textBox1.Focus();
                
            }
            else if (guess > ans)
            {
                label1.Text = "太大了請重猜。" ;
                textBox1.Focus();
                

            }

        }
    }
}
