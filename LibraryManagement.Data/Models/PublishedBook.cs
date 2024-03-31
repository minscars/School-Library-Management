namespace LibraryManagement.Data.Models
{
    public class PublishedBook
    {
        public string Id { get; set; }
        public string BookId { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public string? Image {  get; set; }
        public string PublisherId { get; set; }
        public int Pages { get; set; }
        public int? PublishedYear { get; set; }
        public double Rating { get; set; }
        public int Checkout_visit {  get; set; }
        public virtual Book Book { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual List<FeedBack> FeedBacks { get; set; }   
        public virtual List<BookDetail> BookDetails { get; set; }
        public virtual List<BookRequest>? BookRequests { get; set; }
        public virtual List<BookShelfDetail>? BookShelfDetails { get; set; }
    }
}
