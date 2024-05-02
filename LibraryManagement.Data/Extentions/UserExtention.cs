using LibraryManagement.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Extentions
{
    public static class UserExtention
    {
        public static void FillDataUser(this ModelBuilder modelBuilder)
        {
            //var adminRoleId = new Guid("9E87B492-5343-4272-9A34-FA5DE7CFFB22");
            //var userRoleId = new Guid("8F7579EE-4AF9-4B71-9ADA-7F792F76DC31");
            //var adminId = new Guid("372EA575-2536-4076-9BAB-3E3138DE495F");
            //var userId = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4");
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = "8A820ADB-93D7-4C6F-9404-BDBFC14419F4",
                    //UserAccountId = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4"),
                    Name = "Lê Minh Kha",
                    UserCode = "B2012213",
                    //Email = "kha@gmail.com",
                    PhoneNumber = "0398897634",
                    Address = "Đường 3/2, phường Xuân Khánh, quận Ninh Kiều, TP. Cần Thơ"
                },
                new User()
                {
                    Id = "BEFE5A8F-B2F6-48C4-AAA0-E4DDA7A3914C",
                    Name = "Nguyễn Tùng Lâm",
                    UserCode = "B1809363",
                    PhoneNumber = "0338307449",
                    Address = "87 Lê Văn Huân, Phường 13, Quận Tân Bình, TP. Hồ Chí Minh"
                },
                new User()
                {
                    Id = "F7AA67C1-B3CB-4CCE-9394-1630407343BF",
                    Name = "Trần Chí Thể",
                    UserCode = "B2003923",
                    PhoneNumber = "1234567890",
                    Address = "Ninh Kiều, TP. Cần Thơ"
                },
                new User()
                {
                    Id = "1B1BC693-F841-4B2D-9567-63710DA34F1D",
                    Name = "Lưu Hoàng Lỉnh",
                    UserCode = "B2012223",
                    PhoneNumber = "0123456789",
                    Address = "Cái Răng, TP. Cần Thơ"
                },
                new User()
                {
                    Id = "D8E5F8D4-09DE-42FA-9952-37AF9BF3EE9B",
                    Name = "Nguyễn Trung Nhẩn",
                    UserCode = "B2012237",
                    PhoneNumber = "0122334455",
                    Address = "Hẻm 51, TP. Cần Thơ"
                },
                new User()
                {
                    Id = "B03DE8D3-DFD7-4A25-B081-20FB1696DB22",
                    Name = "Huỳnh Yến Nhung",
                    UserCode = "B1914237",
                    PhoneNumber = "098769876",
                    Address = "Ký túc xá A, Trường Đại học Cần Thơ"
                }

                );

            //var userId2 = new Guid("2A738BF3-A14B-488E-B04E-17F918E8D6A4");
            //Seed data for UserRole
           // modelBuilder.Entity<UserRole>().HasData(
           //     new UserRole
           //     {
           //         Id = adminRoleId,
           //         Name = "Admin",
           //         NormalizedName = "ADMIN",
           //     },
           //     new UserRole
           //     {
           //         Id = userRoleId,
           //         Name = "User",
           //         NormalizedName = "USER",
           //     }
           //);

            //Seed data for User
            //var hasher = new PasswordHasher<User>();
            //var user = new User()
            //{
            //    Id = userId.ToString(),
            //    Name = "Lê Minh Kha",
            //    UserName = "kha@gmail.com",
            //    NormalizedUserName = "KHA@GMAIL.COM",
            //    Email = "kha@gmail.com",
            //    NormalizedEmail = "KHA@GMAIL.COM",
            //    PhoneNumber = "0398897634",
                
            //};

            //var user2 = new User()
            //{
            //    Id = userId2.ToString(),
            //    Name = "Nguyễn Tùng Lâm",
            //    UserName = "lam@gmail.com",
            //    NormalizedUserName = "LAM@GMAIL.COM",
            //    Email = "lam@gmail.com",
            //    NormalizedEmail = "LAM@GMAIL.COM",
            //    PhoneNumber = "0338307449",
                
            //};

            //var admin = new User()
            //{
            //    Id = adminId,
            //    Name = "John",
            //    UserName = "admin@gmail.com",
            //    NormalizedUserName = "ADMIN@GMAIL.COM",
            //    Email = "admin@gmail.com",
            //    NormalizedEmail = "ADMIN@GMAIL.COM",
            //    PhoneNumber = "0123456789",
                
            //};

            //user.PasswordHash = hasher.HashPassword(user, "kha123");
            //admin.PasswordHash = hasher.HashPassword(admin, "admin123");
            //user2.PasswordHash = hasher.HashPassword(user2, "lam123");
            //modelBuilder.Entity<User>().HasData(user, admin, user2);

            //Seed data for IdentityUserRole

            //modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
            //  new IdentityUserRole<Guid>
            //  {
            //      RoleId = adminRoleId,
            //      UserId = adminId,
            //  },
            //  new IdentityUserRole<Guid>
            //  {
            //      RoleId = userRoleId,
            //      UserId = userId,
            //  },
            //new IdentityUserRole<Guid>
            //{
            //    RoleId = userRoleId,
            //    UserId = userId2,
            //});

            //Seed data for UserClaim
            //modelBuilder.Entity<IdentityUserClaim<Guid>>().HasData(
            //  new IdentityUserClaim<Guid>
            //  {
            //      Id = 1,
            //      UserId = adminId,
            //      ClaimType = "id",
            //      ClaimValue = adminId.ToString()
            //  },
            //  new IdentityUserClaim<Guid>
            //  {
            //      Id = 2,
            //      UserId = adminId,
            //      ClaimType = "email",
            //      ClaimValue = "admin@gmail.com"
            //  },
            //  new IdentityUserClaim<Guid>
            //  {
            //      Id = 3,
            //      UserId = adminId,
            //      ClaimType = "roles",
            //      ClaimValue = "Admin"
            //  },
            //  new IdentityUserClaim<Guid>
            //  {
            //      Id = 4,
            //      UserId = userId,
            //      ClaimType = "id",
            //      ClaimValue = userId.ToString()
            //  },
            //  new IdentityUserClaim<Guid>
            //  {
            //      Id = 5,
            //      UserId = userId,
            //      ClaimType = "email",
            //      ClaimValue = "kha@gmail.com"
            //  },
            //  new IdentityUserClaim<Guid>
            //  {
            //      Id = 6,
            //      UserId = userId,
            //      ClaimType = "roles",
            //      ClaimValue = "User"
            //  },
            //    new IdentityUserClaim<Guid>
            //    {
            //        Id = 7,
            //        UserId = userId2,
            //        ClaimType = "id",
            //        ClaimValue = userId2.ToString()
            //    },
            //    new IdentityUserClaim<Guid>
            //    {
            //        Id = 8,
            //        UserId = userId2,
            //        ClaimType = "email",
            //        ClaimValue = "lam@gmail.com"
            //    },
            //    new IdentityUserClaim<Guid>
            //    {
            //        Id = 9,
            //        UserId = userId2,
            //        ClaimType = "roles",
            //        ClaimValue = "User"
            //    });
        }
    }
}
