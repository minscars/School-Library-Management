using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class BookAuthorExtention
    {
        public static void FillDataBookAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasData(
                new BookAuthor()
                {
                    BookId = "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                    AuthorId = "A001"
                },
                new BookAuthor()
                {
                    BookId = "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                    AuthorId = "A003"
                },
                new BookAuthor()
                {
                    BookId = "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                    AuthorId = "A004"
                }

                );
        }
    }
}
