using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class BlogExtention
    {
        public static void FillDataBlog(this ModelBuilder modelBuilder)
        {
            var userAccountId = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4");
            modelBuilder.Entity<Blog>().HasData(
                new Blog()
                {
                    Id = "BF001",
                    UserAccountId = userAccountId,
                    Title = "Test",
                    Content = "Test",
                    Image = "Test",
                }
                );

        }
        
    }
}
