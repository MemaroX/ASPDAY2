using ASPDAY2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDAY2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ItiContext itiContext;
        public StudentController(ItiContext context)
        {
            itiContext = context;
        }
        public IActionResult Index()
        {
            ICollection<Student> students = itiContext.Students.Take(10).ToList();
            return View(students);
        }


    }
}
