using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _2_laba_oop
{
    public class Voucher
    {
        public Voucher()
        {
            Day = 0;
            Month = 0;
            Duration = 0;
            Country = "";
        }


        [ForeignKey("Tourist")]
        public int Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Duration { get; set; }
        public string Country { get; set; }

        [Required]
        public Tourist Tourist { get; set; }/////////навігаційне поле
    }
}
