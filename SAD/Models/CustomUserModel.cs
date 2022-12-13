using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SAD.Models
{
    public class CustomUserModel : IdentityUser
    {
        [Required]
        public string FName { get; set; }
        [Required]
        public string SName { get; set; }
        //student or teacher
        [Required]
        public string type { get; set; }

    }
}
