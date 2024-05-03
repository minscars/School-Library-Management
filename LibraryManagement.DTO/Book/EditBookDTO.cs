﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Book
{
    public class EditBookDTO
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public List<GetAuthorBookDetail> ListAuthors { get; set; }
    }
}
