using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intputbox函式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          string name =  Microsoft.VisualBasic.Interaction.InputBox("請輸入姓名", "算面積","");           
            this.Text = name;



        }

        private void button1_Click(object sender, EventArgs e)
        {




           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {


                int number1 = Convert.ToInt32(textBox1.Text);
                int number2 = Convert.ToInt32(textBox2.Text);
                string end;
                end = Convert.ToString(number1 * number2);
                label4.Text = end.ToString();
            }
            catch
            {
                MessageBox.Show("輸入錯誤");
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {

         
            MessageBox.Show("感謝使用本程式");
            this.Close();
        }
    }
}
