namespace Achim_Daiana_Lab2Masterat.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Publisher? Publisher { get; set; }
        public Book? Book { get; set; }
    }
}
