using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class Blog
    {
        public string Id { get; set; }
        public Guid UserAccountId { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; } = string.Empty;
        public string? Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PostedDate { get; set;}
        public Boolean? IsDeleted { get; set; }
        public int Status { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
