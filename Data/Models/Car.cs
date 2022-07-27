using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestShop_ASP_Project.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool IsFavourite { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
