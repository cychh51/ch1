using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 求平方2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            int x = 500;
            int y = 250;
            string i = "";
            int 結果 = 0;
            

            try
            {



                do
                {
                    

                    i = Microsoft.VisualBasic.Interaction.InputBox("求平方", "請輸入數字", "在此輸入數字", x, y);

                    結果 = Convert.ToInt32(i);

                    dr = MessageBox.Show((結果 * 結果).ToString(), "結果", MessageBoxButtons.YesNo);



                }
                while (dr == DialogResult.Yes);
            }

            catch
            {

                Application.Exit();
            }

        }
    }
}
