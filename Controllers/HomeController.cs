using Unit1Proj.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Unit1Proj.Controllers
{
    //NEVER EVER DELETE THIS EVER.
    // THIS IS THE ENTIRE REASON THE PAGE SHOWS
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Result()
        {
            return View("Result");
        }
    }
}