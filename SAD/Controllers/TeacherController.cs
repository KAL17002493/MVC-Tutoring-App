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

        //TEACHER PROFILE SECTION
        public async Task<IActionResult> TeacherProfile()
        {
            //Get current user
            var user = await _userManager.GetUserAsync(User);

            //Check if current user exists
            if (user == null)
            {
                return NotFound();
            }

            //Pass the user model to view
            return View(user);
        }

        //Save changes to "About" section
        [HttpPost]
        public async Task<IActionResult> TeacherProfile(CustomUserModel model)
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound();
            }

            user.About = model.About;
            await _userManager.UpdateAsync(user);

            return View(user);
        }

        //Toggle availability
        [HttpPost]
        public async Task<IActionResult> ToggleAvailability()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound();
            }

            user.Available = !user.Available;

            await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(TeacherProfile));
        }

    }
}
