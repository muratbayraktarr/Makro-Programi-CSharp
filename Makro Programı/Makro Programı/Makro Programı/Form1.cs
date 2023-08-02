using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;



namespace Makro_Programı
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);
        int a = 1;
        public Form1()
        {
            InitializeComponent();
            simpleButton2.Hide();
            simpleButton3.Hide();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            sn1.Text = Convert.ToString(trackBar1.Value) + " Saniye";
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            sn2.Text = Convert.ToString(trackBar2.Value) + " Saniye";
        }
        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            sn3.Text = Convert.ToString(trackBar3.Value) + " Saniye";
        }
        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            sn4.Text = Convert.ToString(trackBar4.Value) + " Saniye";
        }
        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            sn5.Text = Convert.ToString(trackBar5.Value) + " Saniye";
        }
        private void trackBar6_ValueChanged(object sender, EventArgs e)
        {
            sn6.Text = Convert.ToString(trackBar6.Value) + " Saniye";
        }
        public void baslat_Click(object sender, EventArgs e)
        {
            a = 2;
            
            simpleButton2.Show();
            simpleButton3.Hide();
                 if (t1.Text != null)
                 {

                     timer1.Enabled = true;
                     timer1.Interval = trackBar1.Value * 1000 + 10;

                 }
                 if (t2.Text != null)
                 {
                     timer2.Enabled = true;
                     timer2.Interval = trackBar2.Value * 1000 + 20;
                    
                 }
                 if (t3.Text != null)
                 {
                     timer3.Enabled = true;
                     timer3.Interval = trackBar3.Value * 1000 + 40;
                  
                 }
                 if (t4.Text != null)
                 {
                     timer4.Enabled = true;
                     timer4.Interval = trackBar4.Value * 1000 + 60;
                   
                 }
                 if (t5.Text != null)
                 {
                     timer5.Enabled = true;
                     timer5.Interval = trackBar5.Value * 1000 + 80;
                    
                 }
                 if (t6.Text != null)
                 {
                     timer6.Enabled = true;
                     timer6.Interval = trackBar6.Value * 1000;
                    
                 }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(a == 2)
            {
                 Random rnd = new Random();
                 int num = rnd.Next(200);
                 SendKeys.Send(t1.Text);
                 timer1.Interval = trackBar1.Value * 1000 + num;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (a == 2)
            {
             Random rnd2 = new Random();
            int num2 = rnd2.Next(200,300);
            SendKeys.Send(t2.Text);
            timer2.Interval = trackBar2.Value * 1000 + num2;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (a == 2)
            {
            Random rnd3 = new Random();
            int num3 = rnd3.Next(350,400);
            SendKeys.Send(t3.Text);
            timer3.Interval = trackBar3.Value * 1000 + num3;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (a == 2)
            {
            Random rnd4 = new Random();
            int num4 = rnd4.Next(300);
            SendKeys.Send(t4.Text);
            timer4.Interval = trackBar4.Value * 1000 + num4;
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (a == 2)
            {
            Random rnd5 = new Random();
            int num5 = rnd5.Next(300);
            SendKeys.Send(t5.Text);
            timer5.Interval = trackBar5.Value * 1000 + num5;
            }
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (a == 2)
            {
            Random rnd6 = new Random();
            int num6 = rnd6.Next(300);
            SendKeys.Send(t6.Text);
            timer6.Interval = trackBar6.Value * 1000 + num6;
            }
        }
        private void durdur_Click(object sender, EventArgs e)
        {
            a = 1;
            simpleButton3.Show();
            simpleButton2.Hide();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("TR02 0001 0023 3394 1009 7550 01");
            MessageBox.Show("      \tMurat Bayraktar\nTR02 0001 0023 3394 1009 7550 01\n \tZiraat Bankası\n           Panoya Kopyalandı ✓","Donate",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void baslat_MouseClick(object sender, MouseEventArgs e)
        {
            baslat.BackColor = Color.Green;
        }
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Z)
            {
                a = 2;
                if (t1.Text != null)
                {

                    timer1.Enabled = true;
                    timer1.Interval = trackBar1.Value * 1000 + 10;

                }
                if (t2.Text != null)
                {
                    timer2.Enabled = true;
                    timer2.Interval = trackBar2.Value * 1000 + 20;

                }
                if (t3.Text != null)
                {
                    timer3.Enabled = true;
                    timer3.Interval = trackBar3.Value * 1000 + 40;

                }
                if (t4.Text != null)
                {
                    timer4.Enabled = true;
                    timer4.Interval = trackBar4.Value * 1000 + 60;

                }
                if (t5.Text != null)
                {
                    timer5.Enabled = true;
                    timer5.Interval = trackBar5.Value * 1000 + 80;

                }
                if (t6.Text != null)
                {
                    timer6.Enabled = true;
                    timer6.Interval = trackBar6.Value * 1000;

                }
                simpleButton2.Show();
                simpleButton3.Hide();
            }
            if(e.KeyCode == Keys.X)
            {
                a = 1;
                simpleButton3.Show();
                simpleButton2.Hide();
            }
        }

       
    }
}
