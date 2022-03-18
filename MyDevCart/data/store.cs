using MyDevCart.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyDevCart.data
{
    public class store
    {
        public static List<Project> Getstore()
        {
            return new List<Project>()
            {
                new Project( 1 ,"محصول شماره یک","این یک محصول است که یه شما کمک می کند","project-1.jpg","nasa"),
                new Project( 2 ,"محصول شماره دو","این یک محصول است که یه شما کمک می کند","project-2.jpg","nasa"),
                new Project( 3 ,"محصول شماره سه","این یک محصول است که یه شما کمک می کند","project-3.jpg","nasa"),
                new Project( 4 ,"محصول شماره چهارم","این یک محصول است که یه شما کمک می کند","project-4.jpg","nasa"),


            };
        }

        public static Project getby(long id)
        {
            return Getstore().FirstOrDefault(x => x.Id == id);
        }
    }
}
