﻿using Microsoft.AspNetCore.Identity;
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

            // Get all the users in the role
            var usersInRole = await _userManager.GetUsersInRoleAsync(role.Name);

            // Return the view with the list of users
            return View(usersInRole);
        }
    }
}