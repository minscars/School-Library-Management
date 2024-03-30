using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Data.Models
{
    public class User 
    {
        public string Id { get; set; }
        public string UserCode { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public virtual UserAccount? UserAccount { get; set; }
    }
}
