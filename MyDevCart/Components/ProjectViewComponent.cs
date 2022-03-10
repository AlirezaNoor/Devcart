using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyDevCart.Models;

namespace MyDevCart.Components
{
    public class ProjectViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project( 1 ,"محصول شماره یک","این یک محصول است که یه شما کمک می کند","project-1.jpg","nasa"),
                new Project( 2 ,"محصول شماره دو","این یک محصول است که یه شما کمک می کند","project-2.jpg","nasa"),
                new Project( 3 ,"محصول شماره سه","این یک محصول است که یه شما کمک می کند","project-3.jpg","nasa"),
                new Project( 4 ,"محصول شماره چهارم","این یک محصول است که یه شما کمک می کند","project-4.jpg","nasa"),


            };
            return View("_project",projects);
        }
    }
}
