using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 收銀機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            


            int 一千指定 = 0;
            int 五百指定 = 0;
            int 一百指定 = 0;
            int 五十指定 = 0;
            int 十元指定 = 0;
            int 五元指定 = 0;
            int 一元指定 = 0;


            string 錯誤 = "輸入錯誤";
            string 請輸入數字 = "請輸入數字";

            try
            {

            int textbox1_輸入 = Convert.ToInt32(textBox1.Text);
            int textbox2_輸入 = Convert.ToInt32(textBox2.Text);
            int textbox_內容 = textbox1_輸入 - textbox2_輸入;
            textBox3.Text = textbox_內容.ToString();





                if (textbox1_輸入 < textbox2_輸入)
                {

                    MessageBox.Show(錯誤);

                }



                for (int i = Convert.ToInt32(textBox3.Text); i >= 1000; i -= 1000)
                {

                    一千指定 += 1;

                }

                textBox4.Text = 一千指定.ToString();





                for (int j = Convert.ToInt32(textBox3.Text) - ((Convert.ToInt32(textBox4.Text) * 1000)); j >= 500; j -= 500)
                {

                    五百指定 += 1;

                }
                textBox5.Text = 五百指定.ToString();




                for (int k = Convert.ToInt32(textBox3.Text) - ((Convert.ToInt32(textBox4.Text) * 1000) + (Convert.ToInt32(textBox5.Text) * 500)); k >= 100; k -= 100)
                {


                    一百指定 += 1;

                }
                textBox6.Text = 一百指定.ToString();




                for (int q = Convert.ToInt32(textBox3.Text) - (Convert.ToInt32(textBox4.Text) * 1000 + Convert.ToInt32(textBox5.Text) * 500 + Convert.ToInt32(textBox6.Text) * 100); q >= 50; q -= 50)
                {


                    五十指定 += 1;


                }
                textBox7.Text = 五十指定.ToString();


                for (int y = Convert.ToInt32(textBox3.Text) - ((Convert.ToInt32(textBox4.Text) * 1000) + (Convert.ToInt32(textBox5.Text) * 500) + (Convert.ToInt32(textBox6.Text) * 100) + (Convert.ToInt32(textBox7.Text) * 50)); y >= 10; y -= 10)
                {


                    十元指定 += 1;


                }
                textBox8.Text = 十元指定.ToString();




                for (int g = Convert.ToInt32(textBox3.Text) - ((Convert.ToInt32(textBox4.Text) * 1000) + (Convert.ToInt32(textBox5.Text) * 500) + (Convert.ToInt32(textBox6.Text) * 100) + (Convert.ToInt32(textBox7.Text) * 50) + (Convert.ToInt32(textBox8.Text) * 10)); g >= 5; g -= 5)
                {


                    五元指定 += 1;


                }
                textBox9.Text = 五元指定.ToString();

                for (int h = Convert.ToInt32(textBox3.Text) - ((Convert.ToInt32(textBox4.Text) * 1000) + (Convert.ToInt32(textBox5.Text) * 500) + (Convert.ToInt32(textBox6.Text) * 100) + (Convert.ToInt32(textBox7.Text) * 50) + (Convert.ToInt32(textBox8.Text) * 10) + (Convert.ToInt32(textBox9.Text) * 5)); h >= 1; h -= 1)
                {


                    一元指定 += 1;


                }


                textBox10.Text = 一元指定.ToString();

            }

            catch
            {


                MessageBox.Show(請輸入數字);


            }

        }
    }
}
