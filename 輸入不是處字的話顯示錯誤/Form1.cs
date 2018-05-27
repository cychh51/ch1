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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        



        private void button1_Click(object sender, EventArgs e)
        {

            string a = Convert.ToString(textBox1.Text);
            int B;
            string 錯誤 = "錯誤";

            if(int.TryParse(a, out B) == false)
            {

                MessageBox.Show(錯誤);
                return;

            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
