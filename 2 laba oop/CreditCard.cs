using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public class CreditCard
    {
        public string Number { get; set; }
        public int CVC { get; set; }
        public int MoneyCount { get; set; }

        public int PayHistory { get; set; }
        public CreditCard(string num,int cvc,int money)
        {
            Number = num;
            CVC = cvc;
            MoneyCount = money;
        }
    }
}
