using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Extentions
{
    public static class BookShelfDetailExtension
    {
        public static void FillDataBookShelfDetail(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookShelfDetail>().HasData(
                new BookShelfDetail()
                {
                    Id = "c5103159-813c-48a5-b5b0-b3d12185fb10",
                    BookShelfId = "aedab447-dd1f-4dad-becf-aa74ed03fe7b",
                    PublishedBookId = "7F33BDA5-7C2B-447A-89E3-DC670ACC3646"
                },
                new BookShelfDetail()
                {
                    Id = "e6ef33c8-e912-43ef-af95-03b07bc4f2e9",
                    BookShelfId = "8a509337-277f-4c0d-94d8-e693ccf58a96",
                    PublishedBookId = "FB51AB25-2788-4B0E-996E-2A68282B2C88"
                }
            );
        }
    }
}
