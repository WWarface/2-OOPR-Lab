using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace _2_laba_oop
{
    public class Tourist1
    {

        public Tourist1()
        {
            Vouchers = new HashSet<Voucher1>();
            Cards = new HashSet<CreditCard>();
        }

        public Tourist1(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        [Required]
        public virtual User UserNavigation { get; set; }
        public virtual ICollection<CreditCard> Cards { get; set; }
        public virtual ICollection<Voucher1> Vouchers { get; set; }

    }
}
