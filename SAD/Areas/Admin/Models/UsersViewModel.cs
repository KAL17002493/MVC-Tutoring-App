using SAD.Models;

namespace SAD.Areas.Admin.Models
{
    public class UsersViewModel
    {
        public CustomUserModel ?User { get; set; }
        public List<string> ?Roles { get; set; }
    }
}
