using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class BookCheckout
    {
        public string Id { get; set; }
        
        public string? BookDetailCode { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool IsDeleted { get; set; }
        public virtual BookDetail BookDetail { get; set; }  
    }
}
