using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digital_clock
{
   public class Clock
    {
        public int min { get; set; }
        public int sec { get; set; }
        public string value { get; set; }
        public Clock(int m, int s)
        {
            min = m; sec = s;
            value = m.ToString() + ":" + s.ToString();
        }
        public Clock(string v)
        {
            value = v;
            var tokens = v.Split(new string[] { ":" }, StringSplitOptions.None);
            min = int.Parse(tokens[0]);
            sec = int.Parse(tokens[1]);
        }
    }
}
