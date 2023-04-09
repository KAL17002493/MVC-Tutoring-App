using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAD.Areas.Admin.Models;
using SAD.Models;

namespace SAD.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<CustomUserModel> _userManager;

       // public UsersController(RoleManager<IdentityRole> roleManager, UserManager<CustomUserModel> userManager)
       // {
            //_roleManager = roleManager;
         //   _userManager = userManager;
        //}

       /*public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userList = new List<UsersViewModel>();
            foreach (var user in users)
            {
                var currentUser = new UsersViewModel()
                {
                    User = user,
                    Roles = new List<string>(await _userManager.GetRolesAsync(user))
                };
                userList.Add(currentUser);
            }
            return View(userList);
        }*/

        public IActionResult Index()
        {
            return View();
        }
    }
}
