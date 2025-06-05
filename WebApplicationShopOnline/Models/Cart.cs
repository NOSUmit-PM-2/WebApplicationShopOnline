using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationShopOnline.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public decimal Cost
        {
            get { return CartItems.Sum(x => x.Cost); }
        }
    }
}
