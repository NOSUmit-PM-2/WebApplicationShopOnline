namespace WebApplicationShopOnline.Models
{
    public class Product
    {
        static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public decimal Cost { get; set; }
        public string PathImage { get; set; }

        public Product(string name, string description, decimal cost, string pathImage)
        {
            Id = instanceCounter;
            Name = name;
            Description = description;
            Cost = cost;
            instanceCounter++;
            PathImage = pathImage;
        }

        public override string ToString()
        {
            return String.Join("\n", new String[]{Id.ToString(), Name, Cost.ToString(), Description });
        }


    }
}
