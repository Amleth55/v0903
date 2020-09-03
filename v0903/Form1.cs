using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-21, 21);
        int vy = rand.Next(-21, 21);

        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += vy;
            label1.Left += vx;
        }
    }
}
