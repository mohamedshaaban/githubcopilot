using Microsoft.AspNetCore.Mvc;

namespace Rentik.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
