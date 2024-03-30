using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class Publisher
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public virtual List<PublishedBook> PublishedBooks { get; set; }
    }
}
