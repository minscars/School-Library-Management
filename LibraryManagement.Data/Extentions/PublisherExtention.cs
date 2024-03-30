using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class PublisherExtention
    {
        public static void FillDataPublisher(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher()
                {
                    Id = "4D9FF82E-2B49-47D8-B5ED-43FEE479883D",
                    Name = "Nhà xuất bản Kim Đồng",
                },
                new Publisher()
                {
                    Id = "B1049AEC-30EA-4C8C-8DCC-D35F3AC17C90",
                    Name = "Nhà xuất bản Trẻ",
                },
                new Publisher()
                {
                    Id = "1712E51B-0E16-41AC-8CC4-28BCDFCA9A98",
                    Name = "Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh",
                },
                new Publisher()
                {
                    Id = "1E81F92D-2DB9-44CA-99B4-980B51D1E0C7",
                    Name = "Nhà xuất bản Trường Đại học Cần Thơ"
                },
                new Publisher()
                {
                    Id = "F28F2290-EE06-4831-9091-8124FE61DFB9",
                    Name = "Nhà xuất bản Lao động"
                },
                new Publisher()
                {
                    Id = "A1D207B4-F571-4447-8FE0-E00B2F2D2724",
                    Name = "Nhà xuất bản Hội Nhà Văn"
                },
                new Publisher()
                {
                    Id = "E1B5B1AB-69C9-4D5A-8148-3823605D855A",
                    Name = "Nhà xuất bản Đại học Cần Thơ"
                }

                ) ;

        }
    }
}
