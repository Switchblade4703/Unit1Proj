using Unit1Proj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Unit1Proj.Controllers
{
    //NEVER EVER DELETE THIS EVER.
    // THIS IS THE ENTIRE REASON THE PAGE SHOWS
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Methods a)
        {
            // a.Name += "changed";
            ViewBag.Fighter = a.Fighter();
            return View(a);
        }

        public IActionResult Result()
        {
            return View("Cheatsheet");
        }
    }
}