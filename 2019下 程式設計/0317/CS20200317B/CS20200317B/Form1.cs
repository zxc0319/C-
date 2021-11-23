using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS20200317B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display.Text = DateTime.Now.ToString();
        }

        private void Display_DoubleClick(object sender, EventArgs e)
        {
            Display.Text = DateTime.Now.ToString();
        }

        private void Display_MouseEnter(object sender, EventArgs e)
        {
            Display.Text = DateTime.Now.ToString();
        }

        private void Display_MouseLeave(object sender, EventArgs e)
        {
            Display.Text ="資管一乙";            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Display.Text = DateTime.Now.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = ! timer1.Enabled;
            if (timer1.Enabled)
            {
                Switch.Text = "OFF";
                Switch.BackColor = Color.Green;
            }
            else
            {
                Switch.Text = "ON";
                Switch.BackColor = Color.Red;
            }
        }
    }
}
