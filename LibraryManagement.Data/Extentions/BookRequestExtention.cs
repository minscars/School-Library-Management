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
    public static class BookRequestExtention
    {
        public static void FillDataBookRequest(this ModelBuilder modelBuilder)
        {
            //var bookRequestCode = new Guid("ABEED79C-1EBD-42E3-A3D5-9C275A3512DD");
            modelBuilder.Entity<BookRequest>().HasData(
                new BookRequest()
                {
                    Id = "1406E765-B3C6-4FC3-A25F-2154E7EAC5DB",
                    Code = SystemConstant.BOOKREQUEST_PREFIX + $"{DateTime.Now:yyyyMMddHHmmss}",
                    BookDetailId = "da4b76e3-2d86-4f50-ab6e-c93a73d10e0e",
                    //BookCheckoutId = "BC001",
                    UserAccountId = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4"),
                    Status = 3,
                });
        }
    }
}
