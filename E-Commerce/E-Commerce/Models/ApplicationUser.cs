using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    /// <summary>
    /// User Model 
    /// </summary>
    public class ApplicationUser: IdentityUser
    {
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

    }

    /// <summary>
    /// Roles that those users can be assigned
    /// </summary>
    public static class ApplicationRoles
    {
        public const string Member = "Member";
        public const string Admin = "Admin";
    }
}
