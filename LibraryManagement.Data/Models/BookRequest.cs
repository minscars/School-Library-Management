using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class BookRequest
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string BookDetailId { get; set; }
        public Guid UserAccountId { get; set; }
        public string? BookCheckoutId { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? RejectedTime { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public DateTime? BorrowedTime { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public DateTime? DueTime { get; set; }
        public DateTime? ReturnedTime { get; set; }
        public DateTime? CanceledTime { get; set; }
        public bool IsDeleted { get; set; }
        public string? Note {  get; set; }
        public virtual BookDetail BookDetail { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
