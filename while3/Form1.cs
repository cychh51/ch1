using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
                    
            
     

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


            string 答案 = "";
            

            int 輸入1 = Convert.ToInt32(textBox1.Text);
            int 輸入2;

                for ( 輸入2 = Convert.ToInt32(textBox2.Text); 輸入2 <= 輸入1; 輸入2 += 3)
                {
                    答案 += 輸入2 + " ";
                }
                label1.Text = 答案;

            }



            catch
            {

                string 錯誤 = "錯誤";

                MessageBox.Show(錯誤);

            }

        }
    }
}
