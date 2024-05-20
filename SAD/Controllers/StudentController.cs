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
            int pageSize = 8;

            var role = await _roleManager.FindByNameAsync("Tutor");
            if (role == null)
            {
                return NotFound();
            }

            var currentUser = await _userManager.GetUserAsync(User);

            var studentSubjects = await _context.UserSubject
                .Where(us => us.UserId == currentUser.Id && us.IsTeachable == false)
                .Select(us => us.SubjectId)
                .ToListAsync();

            var allTutors = (await _userManager.GetUsersInRoleAsync(role.Name)).ToList();

            // Find the teachers the user is already following
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

            // Exclude teachers whom the user is already following and teachers who are not available
            var publicTeachers = allTutors.Where(t => t.Available && !followedTeachers.Any(ft => ft.Id == t.Id)).ToList();

            // Get all the UserSubjects for the tutors in a single database query
            var allTutorSubjects = await _context.UserSubject
                .Where(us => publicTeachers.Select(t => t.Id).Contains(us.UserId) && us.IsTeachable == true)
                .ToListAsync();

            var tutorMatches = new List<Tuple<CustomUserModel, int>>();

            // Use Parallel.ForEach for concurrent processing
            Parallel.ForEach(publicTeachers, tutor =>
            {
                var tutorSubjects = allTutorSubjects
                    .Where(us => us.UserId == tutor.Id)
                    .Select(us => us.SubjectId)
                    .ToList();

                var matchCount = tutorSubjects.Intersect(studentSubjects).Count();

                lock (tutorMatches)
                {
                    tutorMatches.Add(Tuple.Create(tutor, matchCount));
                }
            });

            tutorMatches = tutorMatches.OrderByDescending(tm => tm.Item2).ToList();

            var pagedTutorMatches = tutorMatches
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new TeacherScreenViewModel
            {
                FollowedTeachers = followedTeachers,
                PublicTeachers = publicTeachers,
                Tutors = pagedTutorMatches,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(tutorMatches.Count / (double)pageSize)
            };

            // Return data to the view
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

        //Get booken lessons from database for logged in student for current week
        public async Task<IActionResult> BookedLessons()
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Get the start and end of the week
            DateTime startOfWeek;

            //Determins start of current week (Monday) based on todays date
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                //It today is sunday figures out last weeks monday because C# considers Sunday starts of week not monday
                startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek - 6);
            }
            else
            {
                //If today is not sunday calculates current weeks monday
                startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            }

            //Calcuates the end of the week date
            var endOfWeek = startOfWeek.AddDays(7);

            // Get the list of lessons where the current user is the tutor and include the Student information
            var lessons = await _context.Booking
                .Include(b => b.Tutor)
                .Where(b => b.StudentId == currentUser.Id && b.TimeSlot >= startOfWeek && b.TimeSlot < endOfWeek)
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

        //Find Teacher by their Teacher code
        [HttpPost]
        public IActionResult FindTeacher(string teacherCode)
        {
            //Check if the teacher code is empty, if empty reload the page
            if (string.IsNullOrEmpty(teacherCode))
            {
                return RedirectToAction("TeacherScreen", "Student");
            }

            //Get the user with the provided teacher code
            var user = _context.Users.FirstOrDefault(u => u.teacherCode == teacherCode);

            //Check if the teacher code exists if not relaod the page
            if (user == null)
            {
                return RedirectToAction("TeacherScreen", "Student");
            }

            //Redirect to the TeacherProfile action in the Student controller
            return RedirectToAction("TeacherProfileScreen", "Student", new { id = user.Id });
        }


        //****Subject Section STUDENT Side****
        // Display the list of subjects
        public async Task<IActionResult> SelectSubjects()
        {
            // Fetch all subjects from the database
            var subjects = await _context.Subject.ToListAsync();

            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Fetch the subjects the current user is subscribed to
            var userSubjectIds = await _context.UserSubject
                                                .Where(us => us.UserId == currentUser.Id)
                                                .Select(us => us.SubjectId)
                                                .ToListAsync();

            // Pass the subjects and userSubjectIds to the view
            ViewBag.UserSubjectIds = userSubjectIds;

            return View(subjects);
        }


        // Save the selected subjects
        [HttpPost]
        public async Task<IActionResult> SelectSubjects(List<int> selectedSubjects)
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Fetch the current user's subscribed subjects
            var currentUserSubjects = await _context.UserSubject
                                                     .Where(us => us.UserId == currentUser.Id)
                                                     .ToListAsync();

            // Determine which subjects to add and which to remove
            var selectedSubjectIds = selectedSubjects ?? new List<int>();
            var currentSubjectIds = currentUserSubjects.Select(us => us.SubjectId).ToList();

            var subjectsToAdd = selectedSubjectIds.Except(currentSubjectIds).ToList();
            var subjectsToRemove = currentSubjectIds.Except(selectedSubjectIds).ToList();

            // Add new subscriptions
            foreach (var subjectId in subjectsToAdd)
            {
                var userSubject = new UserSubject
                {
                    UserId = currentUser.Id,
                    SubjectId = subjectId
                };
                await _context.UserSubject.AddAsync(userSubject);
            }

            // Remove unselected subscriptions
            foreach (var subjectId in subjectsToRemove)
            {
                var userSubject = currentUserSubjects.FirstOrDefault(us => us.SubjectId == subjectId);
                if (userSubject != null)
                {
                    _context.UserSubject.Remove(userSubject);
                }
            }

            // Save changes
            await _context.SaveChangesAsync();

            // Redirect to the index action (or any other action you prefer)
            return RedirectToAction("SelectSubjects");
        }




    }
}
