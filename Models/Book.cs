﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Cucu_Denisa_Flavia_Lab2_1_.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }
  
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }


        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
    } //navigation property
}
