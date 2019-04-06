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
        string message;
        DigitalClock clock = new DigitalClock();
        public Form1()
        {
            InitializeComponent();
            clock.Value = "11:11";
            this.Controls.Add(clock);
            message = clock.Minute.ToString() + " - " + clock.Second.ToString();
        }

       
        private void btn_Start_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {

        }

        private void btn_Resume_Click(object sender, EventArgs e)
        {

        }

      
    }
}
