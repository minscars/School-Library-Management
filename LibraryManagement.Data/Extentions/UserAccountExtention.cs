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
            var userAcoount4 = new Guid("5BB18865-B42E-4EF0-844F-9AC649AB1732");
            var userAccount5 = new Guid("D1F58D0A-78FC-4564-8642-3B63D71763AC");
            var userAccount6 = new Guid("5B01EC43-AFDC-4117-8212-FE47FEB3A5F4");
            var user = new UserAccount()
            {
                Id = userAccountId,
                UserId = "8A820ADB-93D7-4C6F-9404-BDBFC14419F4",
                UserName = "khab2012213@student.ctu.edu.vn",
                NormalizedUserName = "KHAB2012213@STUDENT.CTU.EDU.VN",
                NormalizedEmail = "KHAB2012213@STUDENT.CTU.EDU.VN",
            };

            var user2 = new UserAccount()
            {
                Id = userAccount2,
                UserId = "BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C",
                UserName = "lamb1809363@student.ctu.edu.vn",
                NormalizedUserName = "LAMB1809363@STUDENT.CTU.EDU.VN",
                NormalizedEmail = "LAMB1809363@STUDENT.CTU.EDU.VN"
            };

            var user3 = new UserAccount()
            {
                Id = userAccount3,
                UserId = "F7AA67C1-B3CB-4CCE-9394-1630407343BF",
                UserName = "theb2003923@student.ctu.edu.vn",
                NormalizedUserName = "THEB2003923@STUDENT.CTU.EDU.VN",
                NormalizedEmail = "THEB2003923@STUDENT.CTU.EDU.VN"
            };

            var user4 = new UserAccount()
            {
                Id = userAcoount4,
                UserId = "1B1BC693-F841-4B2D-9567-63710DA34F1D",
                UserName = "linhb2012223@student.ctu.edu.vn",
                NormalizedUserName = "LINHB2012223@STUDENT.CTU.EDU.VN",
                NormalizedEmail = "LINHB2012223@STUDENT.CTU.EDU.VN"
            };

            var user5 = new UserAccount()
            {
                Id= userAccount5,
                UserId = "D8E5F8D4-09DE-42FA-9952-37AF9BF3EE9B",
                UserName = "nhanb2012237@student.ctu.edu.vn",
                NormalizedUserName = "NHANB2012237@STUDENT.CTU.EDU.VN",
                NormalizedEmail = "NHANB2012237@STUDENT.CTU.EDU.VN"
            };
            var user6 = new UserAccount()
            {
                Id = userAccount6,
                UserId = "B03DE8D3-DFD7-4A25-B081-20FB1696DB22",
                UserName = "nhungb1914237@student.ctu.edu.vn",
                NormalizedUserName = "NHUNGB1914237@STUDENT.CTU.EDU.VN",
                NormalizedEmail = "NHUNGB1914237@STUDENT.CTU.EDU.VN"
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
            user4.PasswordHash = hasher.HashPassword(user4, "linh123");
            user5.PasswordHash = hasher.HashPassword(user5, "nhan123");
            user6.PasswordHash = hasher.HashPassword(user6, "nhung123");
            modelBuilder.Entity<UserAccount>().HasData(user,admin,user2,user3, user4, user5, user6);

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
                  ClaimValue = "khab2012213@student.ctu.edu.vn"
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
                ClaimValue = "lamb1809363@student.ctu.edu.vn"
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
                ClaimValue = "theb2003923@student.ctu.edu.vn"
            },
            new IdentityUserClaim<Guid>
            {
                Id = 12,
                UserId = userAccount3,
                ClaimType = "roles",
                ClaimValue = "User"
            },

            new IdentityUserClaim<Guid>
            {
                Id = 13,
                UserId = userAcoount4,
                ClaimType = "id",
                ClaimValue = userAcoount4.ToString()
            },
            new IdentityUserClaim<Guid>
            {
                Id = 14,
                UserId = userAcoount4,
                ClaimType = "email",
                ClaimValue = "linhb2012223@student.ctu.edu.vn"
            },
            new IdentityUserClaim<Guid>
            {
                Id = 15,
                UserId = userAcoount4,
                ClaimType = "roles",
                ClaimValue = "User"
            },


            new IdentityUserClaim<Guid>
            {
                Id = 16,
                UserId = userAccount5,
                ClaimType = "id",
                ClaimValue = userAccount5.ToString()
            },
            new IdentityUserClaim<Guid>
            {
                Id = 17,
                UserId = userAccount5,
                ClaimType = "email",
                ClaimValue = "nhanb2012237@student.ctu.edu.vn"
            },
            new IdentityUserClaim<Guid>
            {
                Id = 18,
                UserId = userAccount5,
                ClaimType = "roles",
                ClaimValue = "User"
            },

            new IdentityUserClaim<Guid>
            {
                Id = 19,
                UserId = userAccount6,
                ClaimType = "id",
                ClaimValue = userAccount6.ToString()
            },
            new IdentityUserClaim<Guid>
            {
                Id = 20,
                UserId = userAccount6,
                ClaimType = "email",
                ClaimValue = "nhungb1914237@student.ctu.edu.vn"
            },
            new IdentityUserClaim<Guid>
            {
                Id = 21,
                UserId = userAccount6,
                ClaimType = "roles",
                ClaimValue = "User"
            }
              );
        }
    }
}
