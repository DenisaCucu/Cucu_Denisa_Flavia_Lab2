using System.ComponentModel.DataAnnotations;

namespace Cucu_Denisa_Flavia_Lab2_1_.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Display(Name = "Publisher")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
