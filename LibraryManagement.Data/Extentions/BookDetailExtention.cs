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
                    Id = "da4b76e3-2d86-4f50-ab6e-c93a73d10e0e",
                    Code = "BD20240306202611",
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                },
                new BookDetail()
                {
                    Id = "4c0dc5ae-c609-4f5b-88eb-f8b81ab59439",
                    Code = "BD20240306202612",
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                },
                new BookDetail()
                {
                    Id = "eb7eae5e-c665-4635-aeb0-b05398f9ca87",
                    Code = "BD20240306202613",
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                }
            ); 
        }
    }
}
