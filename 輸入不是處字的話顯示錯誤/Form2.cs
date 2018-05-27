using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 輸入不是處字的話顯示錯誤
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a;

            string g = Convert.ToString(textBox1.Text);

            bool b = int.TryParse(g, out a);          

            if(b == false)
            {

               

            }





        }
    }
}
