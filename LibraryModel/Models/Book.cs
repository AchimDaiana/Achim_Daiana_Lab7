using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Achim_Daiana_Lab2Masterat.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ICollection<PublishedBook>? PublishedBooks { get; set; }
    }
}
