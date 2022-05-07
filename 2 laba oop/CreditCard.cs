using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{

    public class CreditCard
    {
        public CreditCard()
        {
            Random rnd = new Random();
            MoneyCount = rnd.Next(25000, 45000);
        }
        public int Id { get; set; }

        public string type { get; set; }

        public string Number { get; set; }
        public int CVC { get; set; }
        public double MoneyCount { get; set; }

        public int TouristId { get; set; }

        public virtual Tourist1 Tourist { get; set; }
    }
}
