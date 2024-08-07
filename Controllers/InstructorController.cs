using ASPDAY2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASPDAY2.Controllers
{
    public class InstructorController : Controller
    {
        private readonly ItiContext itiContext;

        public InstructorController(ItiContext context)
        {
            itiContext = context;
        }

        public IActionResult Index()
        {
            ICollection<Instructor> instructors = itiContext.Instructors.Take(10).ToList();
            return View(instructors);
        }
    }
}
