using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 回圈圈
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string show = "";

            for(int i = 1; i <= 4; i++)
            {
                
                  
                        show += "*";                
                    

            }

            MessageBox.Show(show);
          
        }
    }
}
