namespace WebApplicationShopOnline.Models
{
    public class Product
    {
        static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Image {  get; set; }

        public Product(string name, string description, decimal cost,string image = "")
        {
        Id = instanceCounter;
        Name = name;
        Description = description;
        Cost = cost;
        instanceCounter++;
        }
        public override string ToString()
        {
            return $"{Name} {Description} {Cost}";
        }
    }
}
