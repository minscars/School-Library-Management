using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class AuthorExtention
    {
        public static void FillDataAuthor(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = "A001",
                    Name = "Đặng Hoàng Giang"
                },
                new Author()
                {
                    Id = "A002",
                    Name = "Higashino Keigo"
                },
                new Author()
                {
                    Id = "A003",
                    Name = "Nguyễn Công Danh"
                },
                new Author()
                {
                    Id = "A004",
                    Name = "Trần Cao Đệ"
                },
                new Author()
                {
                    Id = "A005",
                    Name = "Huỳnh Xuân Hiệp"
                }
            );
        }
    }
}
