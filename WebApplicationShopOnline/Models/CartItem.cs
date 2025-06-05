using System.ComponentModel.DataAnnotations;

namespace WebApplicationShopOnline.Models
{
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        
        public virtual Cart Cart { get; set; }
    }
}
