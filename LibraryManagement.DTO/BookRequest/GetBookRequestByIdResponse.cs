using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.BookRequest
{
    public class GetBookRequestByIdResponse
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public Guid UserAccountId { get; set; }
        public string UserName { get; set; }
        public string UserAvatar {  get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string PublishedBookId { get; set; }
        public string PublishedBookName { get; set; }
        public string PublishedBookImage { get; set; }
        public int Available {  get; set; }
        public string BookCheckoutId { get; set; }  // this is code book when reader go to library order to take book
        public string BookTaked {  get; set; }
        public string Status { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? RejectedTime { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public DateTime? BorrowedTime { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public DateTime? DueTime { get; set; }
        public DateTime? ReturnedTime { get; set; }
        public DateTime? CanceledTime { get; set; }
        public bool IsDeleted { get; set; }

    }
}
