using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Extentions
{
    public static class UserAccountExtention
    {
        public static void FillDataUserAccount(this ModelBuilder modelBuilder)
        {
            var userRoleId = new Guid("8F7579EE-4AF9-4B71-9ADA-7F792F76DC31");
            var adminRoleId = new Guid("9E87B492-5343-4272-9A34-FA5DE7CFFB22");
            var adminId = new Guid("372EA575-2536-4076-9BAB-3E3138DE495F");

            //Seed data for UserRole
            modelBuilder.Entity<UserRole>().HasData(
            new UserRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
            },
            new UserRole
            {
                Id = userRoleId,
                Name = "User",
                NormalizedName = "USER",
            });
            //End seed data for UserRole

            //Seed data for UserAccount Login into system
            var hasher = new PasswordHasher<UserAccount>();
            var userAccountId = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4");
            
            var user = new UserAccount()
            {
                Id = userAccountId,
                UserId = "8A820ADB-93D7-4C6F-9404-BDBFC14419F4",
                UserName = "kha@gmail.com",
                NormalizedUserName = "KHA@GMAIL.COM",
                NormalizedEmail = "KHA@GMAIL.COM",
            };

            var admin = new UserAccount()
            {
                Id = adminId,
                UserName = "admin@gmail.com",
                
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "0123456789",
            };
            user.PasswordHash = hasher.HashPassword(user, "kha123");
            admin.PasswordHash = hasher.HashPassword(admin, "admin123");
            modelBuilder.Entity<UserAccount>().HasData(user,admin);

            //Seed data for IdentityUserRole
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
              new IdentityUserRole<Guid>
              {
                  RoleId = adminRoleId,
                  UserId = adminId,
              },
              new IdentityUserRole<Guid>
              {
                  RoleId = userRoleId,
                  UserId = userAccountId,
              });

            //Seed data for UserClaim
            modelBuilder.Entity<IdentityUserClaim<Guid>>().HasData(
              new IdentityUserClaim<Guid>
              {
                  Id = 1,
                  UserId = adminId,
                  ClaimType = "id",
                  ClaimValue = adminId.ToString()
              },
              new IdentityUserClaim<Guid>
              {
                  Id = 2,
                  UserId = adminId,
                  ClaimType = "email",
                  ClaimValue = "admin@gmail.com"
              },
              new IdentityUserClaim<Guid>
              {
                  Id = 3,
                  UserId = adminId,
                  ClaimType = "roles",
                  ClaimValue = "Admin"
              },
              new IdentityUserClaim<Guid>
              {
                  Id = 4,
                  UserId = userAccountId,
                  ClaimType = "id",
                  ClaimValue = userAccountId.ToString()
              },
              new IdentityUserClaim<Guid>
              {
                  Id = 5,
                  UserId = userAccountId,
                  ClaimType = "email",
                  ClaimValue = "kha@gmail.com"
              },
              new IdentityUserClaim<Guid>
              {
                  Id = 6,
                  UserId = userAccountId,
                  ClaimType = "roles",
                  ClaimValue = "User"
              });
        }
    }
}
