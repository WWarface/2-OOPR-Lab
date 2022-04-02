using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public delegate void CardHandler();
    public class CreditCard
    {
        public CreditCard(string num, int cvc, double money)
        {
            Number = num;
            CVC = cvc;
            MoneyCount = money;
            Bonus = 0.1;
        }

        public readonly double Bonus;

        private CardHandler CardBooster;
        public string Number { get; set; }
        public int CVC { get; set; }
        public double MoneyCount { get; set; }

        public int PayHistory { get; set; }

    }
}
