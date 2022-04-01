using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public class Voucher
    {
        public Voucher()
        {
            Day = 0;
            Month = 0;
            Duration = 0;
            Country = "";
        }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Duration { get; set; }
        public string Country { get; set; }
    }
}
