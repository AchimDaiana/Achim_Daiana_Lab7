﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Achim_Daiana_Lab2Masterat.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Publisher Name")]
        [StringLength(50)]
        public string? PublisherName { get; set; }

        [StringLength(70)]
        public string? Adress { get; set; }
        public ICollection<PublishedBook>? PublishedBooks { get; set; }
    }
}
