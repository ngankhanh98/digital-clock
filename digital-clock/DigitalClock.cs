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
        public int start = 0;
        public int resume = 0;
        Clock clock = new Clock(0, 0);
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

        private void timer_Tick(object sender, EventArgs e)
        {
            start++;
            if (start < clock.MAX_min * 60 + clock.MAX_sec)
            {
                clock.sec = start % 60;
                num4.Image = img[clock.sec % 10];
                num3.Image = img[clock.sec / 10];
                clock.min = start / 60;
                num2.Image = img[clock.min % 10];
                num1.Image = img[clock.min / 10];
            }
        }

        public void Start()
        {
            num1.Image = img[0];
            num2.Image = img[0];
            num3.Image = img[0];
            num4.Image = img[0];
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
            start = 0;
        }

        public void Pause()
        {
            resume = start;
            timer.Stop();
            start = resume;
        }

        public void Resume()
        {
            if (start == 0)
            {
                num1.Image = img[0];
                num2.Image = img[0];
                num3.Image = img[0];
                num4.Image = img[0];
            }
            timer.Start();
        }
    }
}
