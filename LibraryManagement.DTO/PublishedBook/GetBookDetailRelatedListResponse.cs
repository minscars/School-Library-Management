namespace LibraryManagement.DTO.PublishedBook
{
    public class GetBookDetailRelatedListResponse
    {
        public string Id { get; set; } = null!;
        public string? Code { get; set; }
        public bool IsDeleted { get; set; }
        public string Status { get; set; }
        public DateTime? DueTime { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}
