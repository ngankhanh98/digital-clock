using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_clock
{
    public partial class DigitalClock : UserControl
    {
        Clock clock = new Clock(0, 0);
        public DigitalClock()
        {
            InitializeComponent();

        }

        // Load Digital Clock
        private void DigitalClock_Load(object sender, EventArgs e)
        {
            //timer.Start();
        }

        // properties
        public string Value
        {
            get
            {
                return clock.value;
            }
            set
            {
                clock = new Clock(value);
            }
        }

        public int Minute
        {
            get
            {
                return clock.min;
            }
            set
            {
                clock.min = value;
            }
        }

        public int Second
        {
            get
            {
                return clock.sec;
            }
            set
            {
                clock.sec = value;
            }
        }

        // event
        public int countup = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            countup++;
            //num1.Image = Properties.Resources._3;
        }

        private void DigitalClock_Start(object sender, EventArgs e)
        {
            Image[] img = { Properties.Resources._0,
                Properties.Resources._1,
                Properties.Resources._2,
                Properties.Resources._3,
                Properties.Resources._4,
                Properties.Resources._5,
                Properties.Resources._6,
                Properties.Resources._7,
                Properties.Resources._8,
                Properties.Resources._9 };

            timer.Start();
            num1.Image = img[countup];
        }
    }
}
