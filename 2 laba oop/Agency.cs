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
            tourists = new List<Tourist1>();
        }
        string label;

        public List<Tourist1> tourists;

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

        public Tourist1 this[int index]
        {
            set { tourists[index] = (Tourist1)value; }
            get { return tourists[index]; }
        }




        public static int Count { get; private set; }
        public int Nationality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(Tourist1 tourist)
        {
            tourists.Add(tourist);
            Count++;
        }
    }
}
