using Microsoft.AspNetCore.Mvc;

namespace Guns_of_the_Old_West.Controllers
{
    public class HomeController : Controller
    {
        public static int counter = 13;
        
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

        [HttpGet]
        public IActionResult Verkoop()
        {
            return View();
        }

        
    }
}