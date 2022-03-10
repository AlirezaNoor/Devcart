using System.Reflection.Metadata.Ecma335;

namespace MyDevCart.Models
{
    public class Acrtical
    {
        public long Id { get; set; }
        public string name { get; set; }
        public string disciption { get; set; }
        public string Image { get; set; }

        public Acrtical(long id, string name, string disciption, string image)
        {
            Id = id;
            this.name = name;
            this.disciption = disciption;
            Image = image;
        }
    }
}
