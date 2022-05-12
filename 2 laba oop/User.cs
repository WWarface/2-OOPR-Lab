using System.ComponentModel.DataAnnotations;

namespace _2_laba_oop
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public virtual Tourist1 Tourist1Navigation { get; set; }
    }
}
