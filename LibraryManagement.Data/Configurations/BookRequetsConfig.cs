﻿using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Configurations
{
    public class BookRequetsConfig : IEntityTypeConfiguration<BookRequest>
    {
        public void Configure(EntityTypeBuilder<BookRequest> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);  
        }
    }
}
