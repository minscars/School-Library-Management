using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class FeedBack
    {
        public int Id { get; set; }
        public Guid UserAccountId { get; set; }
        public string? PublishedBookId { get; set; }
        public string? Content { get; set; }
        public double Rate { get; set; }
        public Boolean? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        public virtual PublishedBook PublishedBook { get; set; }    
    }
}
