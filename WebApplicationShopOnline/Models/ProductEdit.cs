using System.ComponentModel.DataAnnotations;

namespace WebApplicationShopOnline.Models
{
    public class ProductEdit
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не указано название продукта")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не указано описание продукта")]
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string PathImage { get; set; }



    }
}
