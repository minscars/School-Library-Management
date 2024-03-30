using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Configurations
{
    public class PublishedBookConfig : IEntityTypeConfiguration<PublishedBook>
    {
        public void Configure(EntityTypeBuilder<PublishedBook> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.PublishedYear).IsRequired();
            builder.Property(x => x.Image).HasDefaultValue("default.png");
        }
    }
}
