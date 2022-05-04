using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public class Destination
    {
        public int Id { get; set; }

        public string Country { get; set; }

        public ICollection<Voucher1> Vouchers1 { get; set; }
    }
}
