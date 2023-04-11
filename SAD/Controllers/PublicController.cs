using Microsoft.AspNetCore.Mvc;

namespace SAD.Controllers
{
    public class PublicController : Controller
    {
        //List of dates for the current month to be passed to the view
        public IActionResult Index()
        {
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

            //Pass the list of dates to the view
            return View(dates);
        }

        public IActionResult DayView(DateTime date)
        {
            //Create a list of periods for the selected date
            List<DateTime> timeIntervals = new List<DateTime>();
            //Loops from 0 to 23
            for (int i = 0; i < 24; i++)
            {
                DateTime start = date.Date.AddHours(i);
                timeIntervals.Add(start);
            }

            //Pass the list of periods and the selected date to the view
            ViewBag.SelectedDate = date;
            return View(timeIntervals);
        }
    }
}
