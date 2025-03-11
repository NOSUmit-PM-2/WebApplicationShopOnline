namespace WebApplicationShopOnline.Models
{
    public class Product
    {
        static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string PathPicture { get; set; }

        public Product(string name, string description, decimal cost, string pathPicture)
        {
            Id = instanceCounter;
            Name = name;
            Description = description;
            Cost = cost;
            PathPicture = pathPicture;
            instanceCounter++;
        }

    }
}
