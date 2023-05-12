using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAD.Data;
using SAD.Migrations;
using SAD.Models;
using static SAD.Models.Enums;

namespace SAD.Controllers
{

    [Authorize(Roles = "Student, Admin")]
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

        public async Task<IActionResult> TeacherScreenAsync(int page = 1)
        {
            //Number of tutors per page
            int pageSize = 8; 

            //Find all tutors by role
            var role = await _roleManager.FindByNameAsync("Tutor");
            if (role == null)
            {
                return NotFound();
            }

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

            //Get all users in the role
            var allTutors = (await _userManager.GetUsersInRoleAsync(role.Name)).ToList();

            //Exclude teacher whom the user is already following and teachers who are not available
            var publicTeachers = allTutors.Where(t => t.Available && !followedTeachers.Any(ft => ft.Id == t.Id)).ToList();

            //Get the total count of public teachers
            var totalPublicTeachers = publicTeachers.Count;

            //Get the current page of public teachers
            publicTeachers = publicTeachers.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            //Create the view model instance
            var viewModel = new TeacherScreenViewModel
            {
                PublicTeachers = publicTeachers,
                FollowedTeachers = followedTeachers,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalPublicTeachers / (double)pageSize)
            };

            //Return data to the view
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

            //Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            //Check if the user is already following the teacher
            var isFollowing = await _context.Follow.AnyAsync(f => f.FollowerId == currentUser.Id && f.FollowingId == teacherProfile.Id);

            //Pass the teacher model and the following status to the view
            var viewModel = new TeacherProfileViewModel
            {
                Teacher = teacherProfile,
                IsFollowing = isFollowing
            };

            // Pass the teacher model to the view
            return View(viewModel);
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
                // User is already following the teacher redirect to the teacher profile page
                return RedirectToAction("TeacherProfileScreen", new { id = teacherId });
            }

            //Create a new Follow object to represent the following relationship
            var follow = new FollowModel
            {
                FollowerId = currentUser.Id,
                FollowingId = teacherId
            };

            //Save the new Follow object to the database
            await _context.Follow.AddAsync(follow);
            await _context.SaveChangesAsync();

            //Redirect to the teacher screen
            return RedirectToAction("TeacherScreen");
        }

        //Display list of teachers that the user is following
        public async Task<IActionResult> FollowingTeachers()
        {
            //Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            //Get the list of Follow objects where the current user is the follower
            var following = await _context.Follow.Where(f => f.FollowerId == currentUser.Id).ToListAsync();

            //Get the list of teacher profiles for the following relationships
            var teachers = new List<CustomUserModel>();
            foreach (var follow in following)
            {
                var teacher = await _userManager.FindByIdAsync(follow.FollowingId);
                teachers.Add(teacher);
            }
            //Return the list of teacher profiles to the view
            return View(teachers);
        }

        //Unfollow teacher
        public async Task<IActionResult> UnfollowTeacher(string teacherId)
        {
            //Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            //Get the Follow object representing the following relationship
            var follow = await _context.Follow.FirstOrDefaultAsync(f => f.FollowerId == currentUser.Id && f.FollowingId == teacherId);
            if (follow == null)
            {
                //The following relationship does not exist redirect to TeacherScreen
                return RedirectToAction("TeacherScreen");
            }

            //Remove the Follow object from the database
            _context.Follow.Remove(follow);
            await _context.SaveChangesAsync();

            //Redirect to the following TeacherScreen
            return RedirectToAction("TeacherScreen");
        }

        public async Task<IActionResult> BookedLessons()
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Get the list of lessons where the current user is the student and include the Tutor information
            var lessons = await _context.Booking
                .Include(b => b.Tutor)
                .Where(b => b.StudentId == currentUser.Id)
                .ToListAsync();

            // Return the list of lessons to the view
            return View(lessons);
        }

        public async Task<IActionResult> CancelLesson(string lessonId)
        {
            //Retrieve the lesson from the database based on the provided lessonId
            var lesson = await _context.Booking.FindAsync(lessonId);

            //Check if the lesson exists
            if (lesson == null)
            {
                return NotFound();
            }

            //Update the status of the lesson to "Cancelled"
            //lesson.Status = BookingStatus.Cancelled;

            // Remove the lesson from the context
            _context.Booking.Remove(lesson);

            // Save the changes to the database
            await _context.SaveChangesAsync();

            //Redirect to the BookedLessons view
            return RedirectToAction("BookedLessons");
        }







    }
}
