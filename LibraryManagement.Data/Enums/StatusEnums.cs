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
            [Display(Name = "Extend")]
            Extend = 8,
        }


        public enum StatusPost : int
        {
            [Display(Name = "Pending")]
            Pending = 1,
            [Display(Name = "Posted")]
            Approve = 2,
            [Display(Name = "Deleted")]
            Rejected = 3,
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
