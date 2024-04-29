using LibraryManagement.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Extentions
{
    public static class TopicExtention
    {
        public static void FillDataTopic(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic()
                {
                    Id = "3A1C8B8E-33AB-4DB7-826F-D58C8DF82C88",
                    Name = "Lập trình",
                },
                new Topic()
                {
                    Id = "D2AB6BB4-0A82-4D2C-B70E-03DD1C3BE23D",
                    Name = "Phỏng vấn",
                }
                );
        }
    }
}
