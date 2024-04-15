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

            var userAccount2 = new Guid("F5AA72EA-A563-4E89-A289-E290814F3C17");
            var userAccount3 = new Guid("F4E9077D-D904-4C9E-860E-7C0373CFDDFF");
            var user = new UserAccount()
            {
                Id = userAccountId,
                UserId = "8A820ADB-93D7-4C6F-9404-BDBFC14419F4",
                UserName = "kha@gmail.com",
                NormalizedUserName = "KHA@GMAIL.COM",
                NormalizedEmail = "KHA@GMAIL.COM",
            };

            var user2 = new UserAccount()
            {
                Id = userAccount2,
                UserId = "BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C",
                UserName = "lam@gmail.com",
                NormalizedUserName = "LAM@GMAIL.COM",
                NormalizedEmail = "LAM@GMAIL.COM"
            };

            var user3 = new UserAccount()
            {
                Id = userAccount3,
                UserId = "F7AA67C1-B3CB-4CCE-9394-1630407343BF",
                UserName = "the@gmail.com",
                NormalizedUserName = "THE@GMAIL.COM",
                NormalizedEmail = "THE@GMAIL.COM"
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
            user2.PasswordHash = hasher.HashPassword(user2, "lam123");
            user3.PasswordHash = hasher.HashPassword(user3, "the123");
            modelBuilder.Entity<UserAccount>().HasData(user,admin,user2,user3);

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
              },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleId,
                UserId = userAccount2,
            },
            new IdentityUserRole<Guid>
            {
                RoleId = userRoleId,
                UserId = userAccount3,
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
              },
            new IdentityUserClaim<Guid>
            {
                Id = 7,
                UserId = userAccount2,
                ClaimType = "id",
                ClaimValue = userAccount2.ToString()
            },
            new IdentityUserClaim<Guid>
            {
                Id = 8,
                UserId = userAccount2,
                ClaimType = "email",
                ClaimValue = "lam@gmail.com"
            },
            new IdentityUserClaim<Guid>
            {
                Id = 9 ,
                UserId = userAccount2,
                ClaimType = "roles",
                ClaimValue = "User"
            },
            new IdentityUserClaim<Guid>
            {
                Id = 10,
                UserId = userAccount3,
                ClaimType = "id",
                ClaimValue = userAccount3.ToString()
            },
            new IdentityUserClaim<Guid>
            {
                Id = 11,
                UserId = userAccount3,
                ClaimType = "email",
                ClaimValue = "the@gmail.com"
            },
            new IdentityUserClaim<Guid>
            {
                Id = 12,
                UserId = userAccount3,
                ClaimType = "roles",
                ClaimValue = "User"
            }
              );
        }
    }
}
