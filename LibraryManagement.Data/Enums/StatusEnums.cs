using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Enums
{
    public static class StatusEnums
    {
        public enum Status : int
        {
            [Display(Name = "Available")]
            Available = 1,
            [Display(Name = "Pending")]
            Pending = 2,
            [Display(Name = "Approve")]
            Approve = 3,
            [Display(Name = "Borrowing")]
            Borrowing = 4,
            [Display(Name = "Returned")]
            Returned = 5,
            [Display(Name = "Rejected")]
            Rejected = 6,
            [Display(Name = "Cancel")]
            Cancel = 7,
        }
        public static string GetDisplayName(Enum enumValue)
        {
            string displayName;
            displayName = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();
            if (String.IsNullOrEmpty(displayName))
            {
                displayName = enumValue.ToString();
            }
            return displayName;
        }

    }
}
