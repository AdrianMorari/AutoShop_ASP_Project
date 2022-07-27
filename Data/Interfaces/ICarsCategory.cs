using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Models;

namespace TestShop_ASP_Project.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
