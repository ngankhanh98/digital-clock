using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {         
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            clock.Visible = true;

            int min = Convert.ToInt32(nUD_min.Value);
            int sec = Convert.ToInt32(nUD_sec.Value);
            clock.end = min * 60 + sec;
            clock.Start();

            clock.ReachTimeLimitEvent += CloseForm;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            clock.Stop();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            clock.Pause();
        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {
            clock.Resume();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //clock.ReachTimeLimitEvent += CloseForm;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            //clock.Stop();
            clock.Visible = false;
            //MessageBox.Show("Hello");
        }
    }
}
