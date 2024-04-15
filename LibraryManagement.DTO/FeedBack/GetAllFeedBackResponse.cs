using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.FeedBack
{
    public class GetAllFeedBackResponse
    {
        public int Total {  get; set; }
        public decimal Rate { get; set; }
        public List<GetFeedBackPublishedBookResponse> ListFeedBacks { get; set; }
    }
}
