using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.Data.Models;

namespace TestShop_ASP_Project.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Electrovehicles", Description = "Modern" },
                    new Category { CategoryName = "Clasic", Description ="Disesel" }
                };
            }
        }
    }
}
