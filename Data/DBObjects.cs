using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Models;

namespace TestShop_ASP_Project.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
                content.Car.AddRange(
                     new Car
                     {
                         Name = "Tesla Model S",
                         ShortDescription = "Быстрый автомобиль",
                         LongDescription = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                         Image = "/images/teslaSHP.jpg",
                         Price = 45000,
                         IsFavourite = true,
                         IsAvailable = true,
                         Category = Categories["Электромобили"]
                     },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDescription = "Тихий и спокойный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Image = "/images/ford_fiesta.jpg",
                        Price = 11000,
                        IsFavourite = false,
                        IsAvailable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDescription = "Дерзкий, как пуля резкий",
                        LongDescription = "Создан для внегородской езды",
                        Image = "/images/bmw_m3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Mercedes S class",
                        ShortDescription = "Уютный и большой",
                        LongDescription = "Лучший автомобиль для комфортной городской езды",
                        Image = "/images/mercedes_s.jpg",
                        Price = 40000,
                        IsFavourite = false,
                        IsAvailable = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDescription = "Бесшумный и экономный",
                        LongDescription = "Удобный автомобиль для городской жизни",
                        Image = "/images/nissan_leaf.jpg",
                        Price = 14000,
                        IsFavourite = true,
                        IsAvailable = true,
                        Category = Categories["Электромобили"]
                    });
            content.SaveChanges();
        }

        private static Dictionary<string, Category> _category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_category == null)
                {
                    var categoryList = new Category[]
                    {
                        new Category { CategoryName = "Электромобили", Description = "Современный вид транспорта" },
                        new Category { CategoryName = "Классические автомобили", Description ="Машины с ДВС" }
                    };

                    _category = new Dictionary<string, Category>();
                    foreach (Category element in categoryList)
                        _category.Add(element.CategoryName, element);
                }
                return _category;
            }
        }
    }
}
