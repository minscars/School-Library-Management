namespace LibraryManagement.DTO.PublishedBook
{
    public class CreatePublishedBookRequest
    {
        public string BookId { get; set; } = null!;
        public string PublisherId { get; set; } = null!;
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Pages { get; set; }
        public int? PublishedYear { get; set; }
    }
}
