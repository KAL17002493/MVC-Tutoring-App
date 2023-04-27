using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SAD.Models;

namespace SAD.Controllers
{

    //[Authorize(Roles = "Student, Admin")]
    public class StudentController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public StudentController(UserManager<CustomUserModel> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TeacherScreenAsync()
        {

            //Find the role
            var role = await _roleManager.FindByNameAsync("Tutor");
            if (role == null)
            {
                return NotFound();
            }

            //Get all users role
            var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name);

            //Return view with list of users
            return View(usersInRole);
        }

        public async Task<IActionResult> TeacherProfileScreen(string id)
        {
            //Get teacher by ID
            var teacherProfile = await _userManager.FindByIdAsync(id);

            //Check if teacher exists
            if (teacherProfile == null)
            {
                return NotFound();
            }

            //Pass the teacher model to view
            return View(teacherProfile);
        }
    }
}
