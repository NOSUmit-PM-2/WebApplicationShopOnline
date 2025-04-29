namespace WebApplicationShopOnline.Models
{
    public class Product
    {
        static int instanceCounter = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string PathPicture { get; set; }

        public Product()
        {
          
        }

        public Product(string name, string description, decimal cost, string pathPicture):this()
        {
            Id = instanceCounter;
            instanceCounter++;
            Name = name;
            Description = description;
            Cost = cost;
            PathPicture = pathPicture;
        }
    }
}
