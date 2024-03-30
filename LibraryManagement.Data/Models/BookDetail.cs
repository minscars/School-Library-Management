using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Models
{
    public class BookDetail
    {
        public string Code { get; set; }
        public string PublishedBookId { get; set; }
        public bool IsAvailable { get; set; } 
        public virtual BookCheckout BookCheckout { get; set; }
        public virtual PublishedBook PublishedBook { get; set; }

    }
}
