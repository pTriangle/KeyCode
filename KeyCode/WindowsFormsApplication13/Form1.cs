using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n;
            label1.Text = e.KeyChar.ToString();
            char c;
            c = Convert.ToChar(label1.Text);
            n = c;
            label2.Text = "#" + n.ToString();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/pTriangle");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Process.Start("http://moveax.pro");
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            label8.Text = "CLICK";
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Text = "CLICK";
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = "Site";
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "GH";
        }
    }
}
