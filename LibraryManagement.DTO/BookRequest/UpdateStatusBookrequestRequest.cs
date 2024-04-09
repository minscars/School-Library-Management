using LibraryManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.BookRequest
{
    public class UpdateStatusBookrequestRequest
    {
        public string BookRequestId { get; set; }
        public string BookDetailId { get; set; }
        public StatusEnums.Status Status { get; set; }
        public string? Note {  get; set; }
        public string? BookTaked { get; set; }
    }
}
