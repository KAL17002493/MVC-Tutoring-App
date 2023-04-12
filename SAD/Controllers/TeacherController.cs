using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAD.Models;

namespace SAD.Controllers
{
    //[Authorize(Roles = "Tutor, Admin")]
    public class TeacherController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TeacherProfile()
        {
            // Create a new instance of the TeacherModel
            var teacherModel = new TeacherModel
            {
                User = new CustomUserModel
                {
                    FName = "John",
                    SName = "Doe",
                    Email = "johndoe@example.com"
                },
                Available = true,
                About = "I am an experienced teacher with 10 years of experience in teaching Math and Science.",
                teacherCode = "ABC123"
            };

            // Pass the TeacherModel instance to the view
            return View(teacherModel);
        }
    }
}
