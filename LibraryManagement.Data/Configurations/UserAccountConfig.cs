using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Configurations
{
    public class UserAccountConfig : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Avatar).HasDefaultValue("avatar-default.png");
            builder.HasOne(x => x.User)
                    .WithOne(x => x.UserAccount)
                    .HasForeignKey<UserAccount>(x => x.UserPracticalId)
                    .IsRequired(false);
                    

        }

    }
}
