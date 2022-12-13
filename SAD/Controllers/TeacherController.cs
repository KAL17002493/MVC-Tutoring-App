using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SAD.Controllers
{
    [Authorize]
    public class TeacherController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
