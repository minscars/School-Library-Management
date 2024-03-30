using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class Comment
    {
        public int Id { get; set; } 
        public string? BlogId { get; set; }
        public Guid UserAccountId { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ReplyCommentId { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
