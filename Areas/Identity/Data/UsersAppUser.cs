using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the UsersAppUser class
    public class UsersAppUser : IdentityUser
    {
        [PersonalData]
        [Column (TypeName = "nvarchar(50)")]
        public string FisrtName { get; set; }

        [PersonalData]
        [Column (TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column (TypeName = "nvarchar(50)")]
        public string EmailAdd { get; set; }

        [PersonalData]
        [Column (TypeName = "nvarchar(7)")]
        public string Password { get; set; }
    }
}
