namespace OnlineShop.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string ProductName { get; set; } // Название товара
        public int Quantity { get; set; }      // Количество
        public decimal Price { get; set; }     // Цена за единицу
    }
}
