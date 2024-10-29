using Microsoft.AspNetCore.Mvc;

namespace Rentik.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
