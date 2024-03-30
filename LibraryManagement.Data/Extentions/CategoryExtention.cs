﻿using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class CategoryExtention
    {
        public static void FillDataCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Tiểu thuyết"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Sách tâm lý"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Sách khoa học"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Từ điển"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Sách văn học"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Giáo trình"
                }
            );
        }
    }
}
