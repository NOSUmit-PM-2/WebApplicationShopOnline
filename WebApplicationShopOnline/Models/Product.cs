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
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Недостаточная длина текста")]
        public string Description { get; set; } 
        public decimal Cost { get; set; }
        public string PathImage { get; set; }
        public Product()
        {
            
        }
        public Product(string name, string description, decimal cost, string pathImage):this()
        {
            Id = instanceCounter;
            instanceCounter++;
            Name = name;
            Description = description;
            Cost = cost;
            PathImage = pathImage;
        }

        public override string ToString()
        {
            return String.Join("\n", new String[]{Id.ToString(), Name, Cost.ToString(), Description });
        }


    }
}
