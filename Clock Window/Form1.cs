using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Window
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            hourState.Text = DateTime.Now.Hour.ToString("00");
            minuteState.Text    = DateTime.Now.Minute.ToString("00");

        }

        private void Clock_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Clock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                fullscreenButton.Visible = true;
                fullscreenExitButton.Visible = false;
            }
            if(e.Alt && e.KeyCode == Keys.Enter)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
                fullscreenButton.Visible = false;
                fullscreenExitButton.Visible = true;
            }
        }

        private void bg1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            fullscreenButton.Visible = false;
            fullscreenExitButton.Visible = true;
        }

        private void fullscreenExitButton_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            TopMost = false;
            fullscreenButton.Visible = true;
            fullscreenExitButton.Visible = false;
        }
    }
}
