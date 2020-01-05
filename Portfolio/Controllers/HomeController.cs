using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult Activities()
        {
            return View();
        }
    }
}