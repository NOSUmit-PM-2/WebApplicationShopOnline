namespace WebApplicationShopOnline.Models
{
    public class Product
    {
        static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public Product(string name, string description, decimal cost)
        {
            Id = instanceCounter;
            Name = name;
            Description = description;
            Cost = cost;
            instanceCounter++;
        }

    }
}
