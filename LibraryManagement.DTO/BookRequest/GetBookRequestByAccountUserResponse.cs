using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.BookRequest
{
    public class GetBookRequestByAccountUserResponse
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string UserName { get; set; }
        public string PublishedBookId { get; set; }
        public string PublishedBookName { get; set; }
        public string PublishedBookImage { get; set; }
        public string UserAccountId { get; set; }
        public string BookDetailCode { get; set; }
        public string BookDetailId { get; set; }  // this is code book when reader go to library order to take book
        public string Status { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? RejectedTime { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public DateTime? BorrowedTime { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public DateTime? DueTime { get; set; }
        public DateTime? ReturnedTime { get; set; }
        public DateTime? CanceledTime { get; set; }
        public DateTime? ExtendedTime { get; set; }
        public bool IsExtended { get; set; }
        public bool IsDeleted { get; set; }

    }
}
