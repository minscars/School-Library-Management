using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class FeedBackExtention
    {
        public static void FillDataFeedBack(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedBack>().HasData(
                new FeedBack()
                {
                    Id = 1,
                    UserAccountId = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4"),
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646",
                    Content = "Test",
                    Rate = 5,
                    CreatedDate = DateTime.Now,
                }
                );

        }
    }
}
