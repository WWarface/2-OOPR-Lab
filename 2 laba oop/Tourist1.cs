using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace _2_laba_oop
{
    class Tourist1
    {

        public Tourist1()
        {
            Vouchers = new List<Voucher1>();
        }

        public Tourist1(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Voucher1> Vouchers { get; set; }//navigation prop
        public int Age { get; set; }

        public User User { get; set; }//navigation prop

        //public Voucher Voucher { get; set; }////navigation prop
    }
}
