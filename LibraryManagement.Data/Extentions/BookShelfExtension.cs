using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Extentions
{
    public static class BookShelfExtension
    {
        public static void FillDataBookShelf(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookShelf>().HasData(
                new BookShelf()
                {
                    Id = "aedab447-dd1f-4dad-becf-aa74ed03fe7b",
                    Name = "SH-001-A",
                },
                new BookShelf()
                {
                    Id = "8a509337-277f-4c0d-94d8-e693ccf58a96",
                    Name = "SH-001-B",
                },
                new BookShelf()
                {
                    Id = "da29aa39-bfca-4405-b8fe-b21ee816f404",
                    Name = "SH-002-A",
                }
            );
        }
    }
}
