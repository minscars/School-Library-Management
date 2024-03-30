using LibraryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.PublishedBook
{
    public class GetPublishedBookResponse
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string Category { get; set; }
        public string PublisherName { get; set; }
        public int? PublishedYear { get; set; }
        public int Pages { get; set; }
        public double Rating { get; set; }
        public int Checkout_visit { get; set; }
        public int Available { get; set; }
        public List<Author> Authors { get; set; }
    }
}
