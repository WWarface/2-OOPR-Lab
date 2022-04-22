using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    class DataContext :DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        { }

        public DbSet<Tourist> Tourists { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
    }
}
