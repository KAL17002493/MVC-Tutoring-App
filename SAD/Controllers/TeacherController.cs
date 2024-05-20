using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SAD.Data;
using SAD.Models;

namespace SAD.Controllers
{
    [Authorize(Roles = "Tutor, Admin")]
    public class TeacherController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        private readonly ApplicationDbContext _dbContext;
        public TeacherController(UserManager<CustomUserModel> userManager, ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
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

            //Count the number of students following the current user
            var studentCount = await _dbContext.Follow
                .Where(f => f.FollowingId == user.Id)
                .CountAsync();

            //Pass the student count to the view through ViewBag
            ViewBag.StudentCount = studentCount;

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

            //Check if the About field is null or empty, and set it to an empty string to avoid errors when saving to database
            user.About = string.IsNullOrEmpty(model.About) ? string.Empty : model.About;

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

        public async Task<IActionResult> RedirectToPublicController()
        {
            // Get the currently logged-in user
            var user = await _userManager.GetUserAsync(User);
            // Redirect to the public profile view with this user's ID
            return RedirectToAction("Index", "Public", new { id = user.Id });
        }

        //Get booken lessons from database for logged in teacher for current week
        public async Task<IActionResult> BookedLessons()
        {
            //Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            //Get the start and end of the week
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

            //Get the list of lessons where the current user is the tutor and include the Student information
            var lessons = await _dbContext.Booking
                .Include(b => b.Student)
                .Where(b => b.TutorId == currentUser.Id && b.TimeSlot >= startOfWeek && b.TimeSlot < endOfWeek)
                .ToListAsync();

            // Return the list of lessons to the view
            return View(lessons);
        }

        //Get all booked lesson time slots from database
        public async Task<IActionResult> AllBookedLessons()
        {
            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Get the list of lessons where the current user is the student and include the Tutor information
            var lessons = await _dbContext.Booking
                .Include(b => b.Student)
                .Where(b => b.TutorId == currentUser.Id)
                .ToListAsync();

            // Return the list of lessons to the view
            return View(lessons);
        }


        //Cancel lessons
        public async Task<IActionResult> CancelLesson(string lessonId)
        {
            //Retrieve the lesson from the database based on the provided lessonId
            var lesson = await _dbContext.Booking.FindAsync(lessonId);

            //Check if the lesson exists
            if (lesson == null)
            {
                return NotFound();
            }

            //Update the status of the lesson to "Cancelled"
            //lesson.Status = BookingStatus.Cancelled;

            // Remove the lesson from the context
            _dbContext.Booking.Remove(lesson);

            // Save the changes to the database
            await _dbContext.SaveChangesAsync();

            //Redirect to the BookedLessons view
            return RedirectToAction("BookedLessons");
        }


        //****Subject Section TUTOR Side****
        // Display the list of subjects
        public async Task<IActionResult> SelectSubjects()
        {
            // Fetch all subjects from the database
            var subjects = await _dbContext.Subject.ToListAsync();

            // Get the current user
            var currentUser = await _userManager.GetUserAsync(User);

            // Fetch the subjects the current user is subscribed to
            var userSubjectIds = await _dbContext.UserSubject
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
            var currentUserSubjects = await _dbContext.UserSubject
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
                    SubjectId = subjectId,
                    IsTeachable = true
                };
                await _dbContext.UserSubject.AddAsync(userSubject);
            }

            // Remove unselected subscriptions
            foreach (var subjectId in subjectsToRemove)
            {
                var userSubject = currentUserSubjects.FirstOrDefault(us => us.SubjectId == subjectId);
                if (userSubject != null)
                {
                    _dbContext.UserSubject.Remove(userSubject);
                }
            }

            // Save changes
            await _dbContext.SaveChangesAsync();

            // Redirect to the index action (or any other action you prefer)
            return RedirectToAction("SelectSubjects");
        }






        public IActionResult ViewSlot()
        {
            return View();
        }

    }
}
