using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Pagination
{
    public class GetPaginationRequest
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search {  get; set; }
        public int? Key { get; set; } //cate
        public int? Type { get; set; }

    }
}
