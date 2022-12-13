using Microsoft.AspNetCore.Mvc;

namespace SAD.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
