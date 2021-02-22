using System;
using Microsoft.AspNetCore.Mvc;

namespace Guns_of_the_Old_West.Controllers
{
    public class HomeController : Controller
    {
        public static int start = 13;
        public static int counter = start;
        
        [HttpGet]
        public IActionResult Index()
        {
            if (counter == 0)
            {
                return RedirectToAction("Verkoop");
            }
            
            //bij het opstarten van de applicatie mag HitOrMiss niet opgeroepen worden
            if (counter == start)
            {
                Decrement();
                return View(counter);
            }
            
            Decrement();

            if (HitOrMiss())
            {
                return RedirectToAction("Winnaar");
            }
            
            return View(counter);
        }

        public void Decrement()
        {
            counter--;
        }

        public Boolean HitOrMiss()
        {
            Random random = new Random();
            //maximum is excluded, dus 10 kan gekozen worden nog als maximum 11 is, 11 niet
            int randomNumber = random.Next(0, 11);

            if (randomNumber >= 0 && randomNumber <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        [HttpGet]
        public IActionResult Winnaar()
        {
            return View(counter);
        }

        
    }
}