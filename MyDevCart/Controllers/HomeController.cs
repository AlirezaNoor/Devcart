using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDevCart.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyDevCart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Conntext()
        {
            var model = new Connntext();
            return View(model);
        }

        [HttpPost]
        public IActionResult Conntext(Connntext con)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.err = "این یک پیغام اشتباه است";
                return View(con);
            }

            ViewBag.secss = "افرین پیام ارسال شد";
            return View();


        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
