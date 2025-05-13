using System.ComponentModel.DataAnnotations;

namespace WebApplicationShopOnline.Models
{
    public class Product
    {
        static int instanceCounter = 0;
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано название продукта")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указано описание продукта")]
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string PathImage { get; set; }


        public Product() 
        {
            Id = instanceCounter;
            instanceCounter++;
        }

        public Product(string name, string description, decimal cost, string pathImage):this()
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
            return $"{Name}, {Description}, {Cost}";
        }

    }
}
