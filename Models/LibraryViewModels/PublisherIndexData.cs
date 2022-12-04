﻿namespace Achim_Daiana_Lab2Masterat.Models.LibraryViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher>? Publishers { get; set; }
        public IEnumerable<Book>? Books { get; set; }
        public IEnumerable<Order>? Orders { get; set; }
    }
}
