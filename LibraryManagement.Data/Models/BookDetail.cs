using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class BookDetail
    {
        public string Id { get; set; } = null!;
        public string Code { get; set; }
        public string PublishedBookId { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsDeleted { get; set; }
        public int Status { get; set; }
        public DateTime? DueTime { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public virtual PublishedBook PublishedBook { get; set; }
        public virtual List<BookRequest> BookRequests { get; set; }
    }
}
