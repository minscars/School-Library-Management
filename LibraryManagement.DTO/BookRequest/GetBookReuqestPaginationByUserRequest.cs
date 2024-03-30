﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.BookRequest
{
    public class GetBookReuqestPaginationByUserRequest
    {
        public int Page {  get; set; }
        public int Limit { get; set; }
        public Guid UserId { get; set; }
    }
}
