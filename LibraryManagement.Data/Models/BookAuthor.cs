using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class BookAuthor
    {
        public string BookId { get; set; }
        public string AuthorId { get; set; }
        public virtual  Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}
