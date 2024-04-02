using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagement.Data.Configurations
{
    public class BookShelfConfig : IEntityTypeConfiguration<BookShelf>
    {
        public void Configure(EntityTypeBuilder<BookShelf> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
        }
    }
}
