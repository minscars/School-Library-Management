using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class CommentExtention
    {
        public static void FillDataComment(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
                new Comment()
                {
                    Id = 1,
                    UserAccountId = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4"),
                    BlogId = "BF001",
                    Content = "Test",
                    CreatedDate = DateTime.Now,
                }
                );

        }
    }
}
