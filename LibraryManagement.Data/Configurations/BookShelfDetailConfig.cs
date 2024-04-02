using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Data.Configurations
{
    public class BookShelfDetailConfig : IEntityTypeConfiguration<BookShelfDetail>
    {
        public void Configure(EntityTypeBuilder<BookShelfDetail> builder)
        {
            
        }
    }
}
