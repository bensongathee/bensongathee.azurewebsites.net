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
        public IActionResult Social_Action_Project()
        {
            return View();
        }
        public IActionResult Entrepreneurship()
        {
            return View();
        }

        public IActionResult Career()
        {
            return View();
        }
        public IActionResult Health()
        {
            return View();
        }
    }
}