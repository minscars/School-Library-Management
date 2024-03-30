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
    public static class PublishedBookExtention
    {
        public static void FillDataPublishedBook(this ModelBuilder modelBuilder)
        {
            var publishedBookId = new Guid("7F33BDA5-7C2B-447A-89E3-DC670ACC3646");
            modelBuilder.Entity<PublishedBook>().HasData(
                new PublishedBook()
                {
                    Id = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                    Code = SystemConstant.PUBLISHEDBOOK_PREFIX + $"{DateTime.Now:yyyyMMddHHmmss}",
                    BookId = "0E9B5F1B-0C7B-4093-9559-D3A7FE380832", //tìm mình trong thế giới hậu tuổi thơ
                    PublisherId = "A1D207B4-F571-4447-8FE0-E00B2F2D2724",
                    Image = "1.png",
                    PublishedYear = 2020,
                    Pages = 404,
                    Rating = 4.3,
                    Checkout_visit = 1
                },
                new PublishedBook()
                {
                    Id = "FB51AB25-2788-4B0E-996E-2A68282B2C88",
                    Code = SystemConstant.PUBLISHEDBOOK_PREFIX + $"{DateTime.Now:yyyyMMddHHmmss}",
                    BookId = "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                    PublisherId = "E1B5B1AB-69C9-4D5A-8148-3823605D855A",
                    Image = "giaotrinhdbclpm.png",
                    PublishedYear = 2012,
                    Pages = 312,
                    Rating = 2.3,
                    Checkout_visit = 1
                }
                );
        }
    }
}
