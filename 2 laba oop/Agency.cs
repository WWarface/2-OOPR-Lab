using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public class Agency
    {
        public Agency()
        {
            tourists = new List<Tourist>();
        }

        public List<Tourist> tourists;

        public static int Count { get; private set; }
        public void Add(Tourist tourist)
        {
            tourists.Add(tourist);
            Count++;
        }
    }
}
