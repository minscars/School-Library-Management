using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.FeedBack
{
    public class CreateNewFeedBackRequest
    {
        public string UserAccountId { get; set; }
        public string? PublishedBookId { get; set; }
        public string? Content { get; set; }
        public double Rate { get; set; }
        public Boolean? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
