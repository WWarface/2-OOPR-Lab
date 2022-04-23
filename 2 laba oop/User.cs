using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2_laba_oop
{
    class User
    {
        [Key]
        [ForeignKey("Tourist1")]
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        [Required]
        public Tourist1 Tourist1 { get; set; }
    }
}
