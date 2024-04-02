namespace LibraryManagement.Data.Models
{
    public class BookShelfDetail
    {
        public string Id { get; set; } = null!;
        public string? PublishedBookId { get; set; }
        public string? BookShelfId { get; set; }
        public bool IsDeleted { get; set; }
        public virtual BookShelf? BookShelf { get; set; }
        public virtual PublishedBook? PublishedBook { get; set; }
    }
}
