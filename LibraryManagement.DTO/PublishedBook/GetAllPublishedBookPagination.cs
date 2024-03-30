using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.PublishedBook
{
    public class GetAllPublishedBookPagination
    {
        [Required]
        [DefaultValue(2)]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int Page { get; set; }

        public string Keyword { get; set; }
    }
}
