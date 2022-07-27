using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestShop_ASP_Project.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public decimal Price { get; set; }
        public string ShopCartId { get; set; }
    }
}
