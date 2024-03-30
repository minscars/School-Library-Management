﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Contants
{
    public class PaginatedList<T>
    {
        public int TotalRecord {  get; set; }
        public int PageNumber { get; set; }
        public int StatusCode { get; set; }
        public T? Data { get; set; }
        public PaginatedList(T? resultData)
        {
            Data = resultData;
        }
    }
}
