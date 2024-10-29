using Microsoft.AspNetCore.Mvc;

namespace Rentik.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form(int a, int b)
        {
            int sum = a + b;
            ViewBag.Sum = sum;
            ViewData["sum"] = sum.ToString();
            ViewData["a"] = a.ToString();
            ViewData["b"] = b.ToString();
            TempData["a"] = a;
            TempData["b"] = b;
            TempData["sum"] = sum;
            return RedirectToAction("form2");
        }
        [HttpGet]
        public IActionResult form2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form2(int a , int b )
        {
            return RedirectToAction("form"); 
        }
        public string getId(int id)
        {
            return "Your Id "+ id ;
        }
        public int sum(int a , int b)
        {
            return a + b ;
        }
    }
}
