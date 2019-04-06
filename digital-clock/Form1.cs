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
            clock.Start();
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

    }
}
