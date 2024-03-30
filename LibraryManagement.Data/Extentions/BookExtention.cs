using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagement.Data.Extentions
{
    public static class BookExtention
    {
        public static void FillDataBook(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
            new Book()
            {
                Id = "0E9B5F1B-0C7B-4093-9559-D3A7FE380832",
                Name = "Tìm mình trong thế giới hậu tuổi thơ",
                CategoryId = 2,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "90B5054A-9A37-4249-B1A1-209FFC7AE80D",
                Name = "Điều kỳ diệu của tiệm tạp hóa Namiya",
                CategoryId = 1,
                IsDeleted = false,

            },
            new Book()
            {
                Id = "34824C95-72D2-4861-A552-75BAC6F9508F  ",
                Name = "Rồi một ngày cuộc sống hóa hư vô",
                CategoryId = 2,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "AFE53773-D1B3-462D-B27E-8D37C1138639",
                Name = "Quán ăn nơi góc hẻm",
                CategoryId = 1,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "A7A7CFF3-5B28-4921-9F06-599A3B14A776",
                Name = "Thần số học",
                CategoryId = 3,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "4B189D0C-7BA7-4EC0-BDC0-089180AAF5FB",
                Name = "Từ điển tiếng Việt",
                CategoryId = 4,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "B575681C-AD00-49E9-B85E-82F738439CBF",
                Name = "Từ điển Hán Việt",
                CategoryId = 4,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "B4A8198D-CE3E-49E4-A476-F7F2C4681B0D",
                Name = "Đất rừng phương nam",
                CategoryId = 5,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "ABF7E859-5FBA-4C19-B842-B442062C8909",
                Name = "Lược sử Trái Đất",
                CategoryId = 3,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "507C99E1-1586-43C1-8831-E7B499C08EE0",
                Name = "Sapien lược sử loài người",
                CategoryId = 3,
                IsDeleted = false,
            },
            new Book()
            {
                Id = "3ECC8999-CAEA-4C31-9A0E-37FF9158427E",
                Name = "Đảm bảo chất lượng phần mềm",
                CategoryId = 6,
                IsDeleted = false,
            }
            );
        }
    }
}
