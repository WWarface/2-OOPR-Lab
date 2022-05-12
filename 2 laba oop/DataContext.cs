using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public class DataContext :DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        { }

        public DbSet<Tourist1> Tourists { get; set; }
        public DbSet<Voucher1> Vouchers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<CreditCard> Cards { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().ToTable("User");
        //    modelBuilder.Entity<User>().HasOne()
        //    base.OnModelCreating(modelBuilder); 

        //}
    }
}
