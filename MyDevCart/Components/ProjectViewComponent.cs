using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyDevCart.data;
using MyDevCart.Models;

namespace MyDevCart.Components
{
    public class ProjectViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = store.Getstore();
            return View("_project",projects);
        }
    }
}
