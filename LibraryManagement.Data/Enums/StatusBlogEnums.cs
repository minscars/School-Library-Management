using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Enums
{
    public class StatusBlogEnums
    {
        public enum StatusBlog : int
        {
            [Display(Name = "Pending")]
            Pending = 1,
            [Display(Name = "Posted")]
            Posted = 2,
            [Display(Name = "Cancel")]
            Cancel = 3
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
