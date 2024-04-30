using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Comment
{
    public class GetListReplyCommnet
    {
        public int Id { get; set; }
        public string BlogId { get; set; }
        public Guid UserAccountId { get; set; }
        public string? UserAvatar { get; set; }
        public string? UserName { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ReplyCommentId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
