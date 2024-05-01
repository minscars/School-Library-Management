using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Blog
{
    public class GetBlogResponse
    {
        public string Id { get; set; }
        public Guid? UserAccountId { get; set; }
        public string? UserName { get; set; }
        public string? Avatar { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Content { get; set; }
        public string? Status { get; set; }
        public int TotalComments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public Boolean? IsDeleted { get; set; }
    }
}
