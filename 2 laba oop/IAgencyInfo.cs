using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public interface IAgencyInfo: INationable
    {
        string Label
        {
            get;
            set;
        }

        IAgencyInfo this[int index]
        {
            get;
            set;
        }
    }
}
