using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAD.Data;
using SAD.Migrations;
using SAD.Models;

namespace SAD.Controllers
{

    //[Authorize(Roles = "Student, Admin")]
    public class StudentController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly ApplicationDbContext _context;

        public StudentController(UserManager<CustomUserModel> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TeacherScreenAsync()
        {
            // Find the role
            var role = await _roleManager.FindByNameAsync("Tutor");
            if (role == null)
            {
                return NotFound();
            }

            // Get all users in the role
            var usersInRole = (await _userManager.GetUsersInRoleAsync(role.Name)).ToList();


            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Get the list of followed teachers for the current user
            var followedTeachers = new List<CustomUserModel>();
            if (currentUser != null)
            {
                var following = await _context.Follow.Where(f => f.FollowerId == currentUser.Id).ToListAsync();
                foreach (var follow in following)
                {
                    var teacher = await _userManager.FindByIdAsync(follow.FollowingId);
                    followedTeachers.Add(teacher);
                }
            }

            // Create the view model
            var viewModel = new TeacherScreenViewModel
            {
                PublicTeachers = usersInRole,
                FollowedTeachers = followedTeachers
            };

            // Return the view with the view model
            return View(viewModel);
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

        //Follow new teacher
        public async Task<IActionResult> FollowTeacher(string teacherId)
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Check if the user is already following the teacher
            var existingFollow = await _context.Follow.FirstOrDefaultAsync(f => f.FollowerId == currentUser.Id && f.FollowingId == teacherId);
            if (existingFollow != null)
            {
                // User is already following the teacher, return an error message or redirect to the teacher profile page
                return RedirectToAction("TeacherProfileScreen", new { id = teacherId });
            }

            // Create a new Follow object to represent the following relationship
            var follow = new FollowModel
            {
                FollowerId = currentUser.Id,
                FollowingId = teacherId
            };

            // Save the new Follow object to the database
            await _context.Follow.AddAsync(follow);
            await _context.SaveChangesAsync();

            // Redirect to the teacher profile page
            return RedirectToAction("TeacherProfileScreen", new { id = teacherId });
        }

        //Display list of teachers that the user is following
        public async Task<IActionResult> FollowingTeachers()
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Get the list of Follow objects where the current user is the follower
            var following = await _context.Follow.Where(f => f.FollowerId == currentUser.Id).ToListAsync();

            // Get the list of teacher profiles for the following relationships
            var teachers = new List<CustomUserModel>();
            foreach (var follow in following)
            {
                var teacher = await _userManager.FindByIdAsync(follow.FollowingId);
                teachers.Add(teacher);
            }

            // Return the list of teacher profiles to the view
            return View(teachers);
        }

        //Unfollow teacher
        public async Task<IActionResult> UnfollowTeacher(string teacherId)
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Get the Follow object representing the following relationship
            var follow = await _context.Follow.FirstOrDefaultAsync(f => f.FollowerId == currentUser.Id && f.FollowingId == teacherId);
            if (follow == null)
            {
                // The following relationship does not exist, return an error message or redirect to the following teachers page
                return RedirectToAction("FollowingTeachers");
            }

            // Remove the Follow object from the database
            _context.Follow.Remove(follow);
            await _context.SaveChangesAsync();

            // Redirect to the following teachers page
            return RedirectToAction("FollowingTeachers");
        }



    }
}
