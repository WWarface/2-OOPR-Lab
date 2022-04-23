using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2_laba_oop
{
    class Voucher1
    {
        public int Id { get; set; }

        public string Destination { get; set; }

        public int TouristId { get; set; }

        public int Price { get; set; }

        public bool IsPaid { get; set; }

        public Tourist1 Tourist { get; set; }


        public ICollection<Destination> Destinations { get; set; }
    }
}
