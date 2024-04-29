using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class Topic
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set;}
        public bool IsDeleted { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}
