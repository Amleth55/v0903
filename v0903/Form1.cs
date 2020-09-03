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
        int[] vx = new int[3];
        int[] vy = new int[3];
        int point = 100;
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            vx[0] = rand.Next(-20, 21);
            vy[0] = rand.Next(-20, 21);
            vx[1] = rand.Next(-20, 21);
            vy[1] = rand.Next(-20, 21);
            vx[2] = rand.Next(-20, 21);
            vy[2] = rand.Next(-20, 21);


            label1.Left = rand.Next(ClientSize.Width - label3.Width);
            label1.Top = rand.Next(ClientSize.Height - label3.Height);

            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);

            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += vy[0];
            label1.Left += vx[0];

            label3.Top += vy[1];
            label3.Left += vx[1];

            label4.Top += vy[2];
            label4.Left += vx[2];

            point--;
            label2.Text = "Score " + point;

            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }


            if (label3.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label3.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            if (label4.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label4.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }




            Point mp = MousePosition;
            mp = PointToClient(mp);

            if ((mp.X >= label1.Left)
                && (mp.X <= label1.Right)
                && (mp.Y >= label1.Top)
                && (mp.Y <= label1.Bottom))
            {
                timer1.Enabled = false;
            }

            if ((mp.X >= label3.Left)
                && (mp.X <= label3.Right)
                && (mp.Y >= label3.Top)
                && (mp.Y <= label3.Bottom))
            {
                timer1.Enabled = false;
            }

            if ((mp.X >= label4.Left)
                && (mp.X <= label4.Right)
                && (mp.Y >= label4.Top)
                && (mp.Y <= label4.Bottom))
            {
                timer1.Enabled = false;
            }

        }



    }
}
