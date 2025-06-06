﻿namespace WebApplicationShopOnline.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal Cost
        {
            get { return CartItems.Sum(x => x.Cost); }
        }
    }
}
