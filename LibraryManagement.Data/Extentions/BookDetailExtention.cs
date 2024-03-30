using LibraryManagement.Data.Contants;
using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class BookDetailExtention
    {
        public static void FillDataBookDetail(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookDetail>().HasData(
                new BookDetail()
                {
                    Code = "BD20240306202611",
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                },
                new BookDetail()
                {
                    Code = "BD20240306202612",
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                },
                new BookDetail()
                {
                    Code = "BD20240306202613",
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                }
                ); 
        }
    }
}
