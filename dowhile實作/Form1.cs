using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dowhile實作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string 內容 = "請輸入數字";
            string 標題 = "求平方";
            string 預設內容 = "";
            string i;
            string 錯誤 = "輸入錯誤";
            int 座標x = 750;
            int 座標y = 250;
            double 輸入 = 0.0;
            DialogResult dr;
            DialogResult br;
            try
            {

                do
                {
                    
                        i = Microsoft.VisualBasic.Interaction.InputBox(內容, 標題, 預設內容, 座標x, 座標y);
                        輸入 = Convert.ToDouble(i);
                        dr = MessageBox.Show(輸入 + "的平方等於" + (輸入 * 輸入).ToString() + "\n是否繼續", "平方", MessageBoxButtons.YesNo);

                    
                }
                while (dr == DialogResult.Yes);




                if (dr == DialogResult.No)
                {
                    br = MessageBox.Show("是否結束?","結束",MessageBoxButtons.YesNo);

                   if(br == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                   
                   
                }

                

            }

            catch
            {

                MessageBox.Show(錯誤);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {





        }
    }
}
