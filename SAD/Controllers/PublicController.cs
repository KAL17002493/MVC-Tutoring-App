using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SAD.Data;
using SAD.Models;
using SAD.Services;
using System.Security.Claims;

namespace SAD.Controllers
{
    public class PublicController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
        private readonly SlotService _slotService;

        public PublicController(UserManager<CustomUserModel> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context, SlotService slotService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _slotService = slotService;
        }

        //List of dates for the current month to be passed to the view
        public async Task<IActionResult> Index(string id)
        {
            //Get teacher by ID
            var teacherProfile = await _userManager.FindByIdAsync(id);

            //Check if teacher exists
            if (teacherProfile == null)
            {
                return NotFound();
            }

            //Get the current date
            DateTime currentDate = DateTime.Now;

            //Get the first day of the current month
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

            //Get the number of days in the current month
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            //Create a list of dates for the current month
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < daysInMonth; i++)
            {
                dates.Add(firstDayOfMonth.AddDays(i));
            }

            //Pass the list of dates and the teacherProfile to the view
            ViewBag.TeacherProfile = teacherProfile;
            return View(dates);
        }



        public async Task<IActionResult> DayViewAsync(string tutorId, DateTime date, DateTime timeInterval)
        {
       
            List<SlotModel> timeIntervals = new List<SlotModel>();
            //Loops from 0 to 23
            for (int i = 0; i < 24; i++)
            {
                DateTime start = date.Date.AddHours(i);
                string id = start.Ticks.ToString() + tutorId;
                bool isAvailable = !_context.Booking.Any(x => x.Id == id);
                bool isToday = start.Hour == DateTime.Now.Hour && start.Day == DateTime.Now.Day;
                bool isOld = start < DateTime.Now;

                timeIntervals.Add(new SlotModel()
                {
                    IsAvailable = isAvailable,
                    SlotTime = start,
                    //Calls the GetCardColor method from the SlotService class to determine the CSS class for the card
                    CardColour = _slotService.GetCardColor(isAvailable, isToday, isOld)
                });
            }

            var bookings = _context.Booking.ToList();

            //Pass the list of periods, the selected date, and the selected time interval to the view
            ViewBag.tutorId = tutorId;
            ViewBag.SelectedDate = date;
            return View(timeIntervals);
        }


        //BOOKING SECTION
        public async Task<IActionResult> BookSlot(DateTime timeIntervals, string tutorId)
        {
            var user = await _userManager.GetUserAsync(User);

            //Check if tutor exists by ID
            if (tutorId == null)
            {
                return NotFound();
            }

            string id = String.Concat(timeIntervals.Ticks.ToString(), tutorId);

            //Creates new sintance of BookingModel
            BookingModel bookingModel = new BookingModel()
            {
                Id = id,
                TutorId = tutorId,
                StudentId = user.Id,
                TimeSlot = timeIntervals,
                Status = Enums.BookingStatus.Pending
            };

            return View(bookingModel);
        }

        [HttpPost]
        public async Task<IActionResult> BookSlot(BookingModel booking)
        {
            booking.Status = Enums.BookingStatus.Booked;
            var result = await _context.Booking.AddAsync(booking);

            await _context.SaveChangesAsync();

            return RedirectToAction("TeacherScreen", "Student");
        }

    }
}
