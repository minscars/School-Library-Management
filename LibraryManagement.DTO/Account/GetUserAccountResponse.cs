using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO.Account
{
    public class GetUserAccountResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Avatar {  get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
