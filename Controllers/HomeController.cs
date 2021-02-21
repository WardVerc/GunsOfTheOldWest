using Microsoft.AspNetCore.Mvc;

namespace Guns_of_the_Old_West.Controllers
{
    public class HomeController : Controller
    {
        public static int counter = 1;
        
        [HttpGet]
        public IActionResult Index()
        {
            if (counter == 0)
            {
                return RedirectToAction("Verkoop");
            }
            
            Decrement();
            return View(counter);
        }

        public void Decrement()
        {
            counter--;
        }

        [HttpPost]
        public IActionResult Index(int kogels)
        {
            counter = kogels;
            return View(counter);
        }

        [HttpGet]
        public IActionResult Verkoop()
        {
            return View();
        }

        
    }
}