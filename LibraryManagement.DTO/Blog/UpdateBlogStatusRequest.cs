using LibraryManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Blog
{
    public class UpdateBlogStatusRequest
    {
        public string BlogId { get; set; }
        public StatusBlogEnums.StatusBlog Status { get; set; }
    }
}
