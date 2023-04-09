using Microsoft.AspNetCore.Mvc;

namespace SAD.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
