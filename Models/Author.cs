using System.ComponentModel.DataAnnotations;

namespace Cucu_Denisa_Flavia_Lab2_1_.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }

}
