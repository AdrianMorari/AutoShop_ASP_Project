using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.Data.Models;

namespace TestShop_ASP_Project.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
