﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SAD.Data;
using SAD.Models;
using System.Security.Claims;

namespace SAD.Controllers
{
    public class PublicController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly ApplicationDbContext _context;

        public PublicController(UserManager<CustomUserModel> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
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
       

            //Create a list of periods for the selected date
            List<DateTime> timeIntervals = new List<DateTime>();
            //Loops from 0 to 23
            for (int i = 0; i < 24; i++)
            {
                DateTime start = date.Date.AddHours(i);
                timeIntervals.Add(start);
            }

            //Pass the list of periods, the selected date, and the selected time interval to the view
            ViewBag.tutorId = tutorId;
            ViewBag.SelectedDate = date;
            return View(timeIntervals);
        }


        //BOOKING SECTION
        public async Task<IActionResult> BookSlot(DateTime timeIntervals, string tutorId)
        {
            //Check if tutor exists by ID
            if(tutorId == null)
            {
                return NotFound();
            }

            //Creates new sintance of BookingModel
            BookingModel bookingModel = new BookingModel()
            {
                Id = timeIntervals.Ticks + tutorId,
                TutorId = await _userManager.FindByIdAsync(tutorId),
                StudentId = await _userManager.GetUserAsync(User),
                TimeSlot = timeIntervals,
                Status = Enums.BookingStatus.Pending
            };

            ViewData["tutorId"] = tutorId;
            return View(bookingModel);
        }

        [HttpPost]
        public IActionResult BookSlot(BookingModel booking)
        {
            return View(booking);
        }

    }
}
