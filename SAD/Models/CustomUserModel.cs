using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SAD.Models
{
    public class CustomUserModel : IdentityUser
    {
        [Required]
        public string ?FName { get; set; }
        [Required]
        public string ?SName { get; set; }

        //Only Teachers should be able to access any page with this info
        public bool Available { get; set; } = true;

        public string About { get; set; } = String.Empty;

        public string teacherCode { get; set; } = String.Empty;
    }
}
