namespace MyDevCart.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string discriptionn { get; set; }
        public string Image { get; set; }
        public string client { get; set; }

        public Project(long id, string name, string discriptionn, string image, string client)
        {
            Id = id;
            Name = name;
            this.discriptionn = discriptionn;
            Image = image;
            this.client = client;
        }
    }
}
