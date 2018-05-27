using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WTFF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += "Load";
            this.Width = 500;
            this.Height = 300;
            this.BackColor = Color.Yellow;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Text += ",Act";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = ",paint";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "Click";
            this.Width = Width + 10;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "Dcilick";
            this.Height = Height + 50;
        }
    }
}
