using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public class Agency: IAgencyInfo
    {
   
        public Agency()
        {
            tourists = new List<Tourist>();
        }
        string label;

        public List<Tourist> tourists;

        public string Label
        {
            set
            {
                label = value;
            }
            get
            {
                return label;
            }
        }

        public Tourist this[int index]
        {
            set { tourists[index] = value; }
            get { return tourists[index]; }
        }




        public static int Count { get; private set; }
        public void Add(Tourist tourist)
        {
            tourists.Add(tourist);
            Count++;
        }
    }
}
