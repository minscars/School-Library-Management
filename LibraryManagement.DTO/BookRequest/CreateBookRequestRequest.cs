﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.BookRequest
{
    public class CreateBookRequestRequest
    {
        public string PublishedBookId { get; set; }
        public string UserAccountId { get; set; }
    }
}
