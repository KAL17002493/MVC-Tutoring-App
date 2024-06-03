using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SAD.Models;
using System.Diagnostics;

namespace SAD.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        private readonly SignInManager<CustomUserModel> _signInManager;

        public HomeController(UserManager<CustomUserModel> userManager, SignInManager<CustomUserModel> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //Autlogin student user
        [HttpGet]
        public async Task<IActionResult> AutoLoginStudent()
        {
            var user = await _userManager.FindByEmailAsync("student@student.com");
            if (user != null)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("TeacherScreen", "Student");
            }

            return RedirectToAction("Login", "Account", "Identity");
        }

        //Autologin tutor user
        [HttpGet]
        public async Task<IActionResult> AutoLoginTutor()
        {
            var user = await _userManager.FindByEmailAsync("tutor@tutor.com");
            if (user != null)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("TeacherProfile", "Teacher");
            }

            return RedirectToAction("Login", "Account", "Identity");
        }

        public async Task<IActionResult> Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                //Check user role and redirect to page depending on it
                var user = await _userManager.GetUserAsync(User);
                if (await _userManager.IsInRoleAsync(user, "Student"))
                {
                    return RedirectToAction("TeacherScreen", "Student");
                }
                else if (await _userManager.IsInRoleAsync(user, "Tutor"))
                {
                    return RedirectToAction("TeacherProfile", "Teacher");
                }
                else
                {
                    // Handle other roles or unexpected scenarios
                    return RedirectToAction("Index", "Home");
                }

            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}