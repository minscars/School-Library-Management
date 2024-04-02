namespace LibraryManagement.Data.Models
{
    public class BookShelf
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}
