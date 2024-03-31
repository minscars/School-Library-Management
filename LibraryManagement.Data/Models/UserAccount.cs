using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class UserAccount : IdentityUser<Guid>
    {
        //public Guid Id { get; set; }
        public string? Avatar {  get; set; }
        public string? UserId { get; set; } //Foreign key
        public virtual User User { get; set; } = null!;
        public virtual List<BookRequest> BookRequests { get; set; }
        public virtual List<FeedBack> FeedBacks { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}
