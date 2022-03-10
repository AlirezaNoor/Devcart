using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyDevCart.Models;

namespace MyDevCart.Components
{
    public class AcrtilViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var acrtils = new List<Acrtical>()
            {
                new Acrtical(1, "angular", "this maghale is 4 u", "blog-post-thumb-1.jpg"),
                new Acrtical(2, "react", "this maghale is 4 u", "blog-post-thumb-2.jpg"),
                new Acrtical(3, "agular2", "this maghale is 4 u", "blog-post-thumb-3.jpg"),
                new Acrtical(4, "view", "this maghale is 4 u", "blog-post-thumb-4.jpg"),

            };
            return View("Acrtil",acrtils);
        }
    }
}
