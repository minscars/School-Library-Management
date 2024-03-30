using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class Book
    {
        public string Id { get; set; } 
        public string? Name { get; set; }      
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public virtual List<PublishedBook> PublishedBooks { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<BookAuthor> BookAuthors { get; set; }
    }
}
