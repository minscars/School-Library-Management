using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.BookRequest
{
    public class GetBookRequestByStatusRequest
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public Guid UserAccountId { get; set; }
        public string UserName { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? DueTime { get; set; }
        public bool IsDeleted { get; set; }

    }
}
