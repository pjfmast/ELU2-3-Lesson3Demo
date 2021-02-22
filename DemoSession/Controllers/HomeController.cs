using DemoSession.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        const string SessionUser = "_SessionUser";
        const string SessionRole = "_Role";

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            HttpContext.Session.SetString(SessionUser, "Henk");
            HttpContext.Session.SetString(SessionRole, "Balie");
            return View();
        }

        public IActionResult Privacy() {
            ViewBag.User = HttpContext.Session.GetString(SessionUser);
            ViewBag.Role = HttpContext.Session.GetString(SessionRole);
            ViewBag.Message = "Dynamic properties!";
            ViewBag.LoginTime = DateTime.Now;
            ViewBag.Keys = HttpContext.Session.Keys;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
