using LibraryManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Book
{
    public class GetAllBookResponse
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedTime { get; set; }
        public List<Author> Authors { get; set; }
    }
}
