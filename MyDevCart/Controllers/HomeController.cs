using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDevCart.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyDevCart.Controllers
{
    public class HomeController : Controller
    {

        readonly private List<Servecces> _mysevice = new List<Servecces>()
        {
           new  Servecces()
           {
                 id = 1,
                 name = "نقرره ایی"
           },
           new  Servecces()
           {
               id = 2,
               name = "طلا ایی"
           },
           new  Servecces()
           {
               id = 3,
               name = "پیلاطین"
           },    new  Servecces()
           {
               id = 4,
               name = "الماس"
           },
        };

        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Conntext()
        {
            var model = new Connntext()
            {
                services = new SelectList(_mysevice,"id","name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Conntext(Connntext con)
        { 
            con.services = new SelectList(_mysevice, "id", "name") ;
            if (!ModelState.IsValid) 
            
            {
               
                ViewBag.err = "این یک پیغام اشتباه است";
                
                return View(con);
            }
            ModelState.Clear();
            var model = new Connntext()
            {
                services = new SelectList(_mysevice, "id", "name")
            };
            ViewBag.secss = "افرین پیام ارسال شد";
            return View(model);


        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
