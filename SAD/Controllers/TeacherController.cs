using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SAD.Data;
using SAD.Models;

namespace SAD.Controllers
{
    [Authorize(Roles = "Tutor, Admin")]
    public class TeacherController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        //private readonly ApplicationDbContext dbContext;
        public TeacherController(UserManager<CustomUserModel> userManager/*, ApplicationDbContext dbContext*/)
        {
            _userManager = userManager;
            //_dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TeacherProfile(CustomUserModel model)
        {
            //Get current user
            var user = await _userManager.GetUserAsync(User);

            //Check if current user exists
            if (user == null) 
            {
                return NotFound();
            }
            else 
            {
            user.About = model.About;
            user.Available = model.Available;
            }

            //UserManager.Update(user);

            //Pass the user model to view
            return View(user);
        }

    }
}
