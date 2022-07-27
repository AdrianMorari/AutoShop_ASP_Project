using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.Data.Models;
using TestShop_ASP_Project.ViewModels;

namespace TestShop_ASP_Project.Data.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult ListCars(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string carCategory = "";
            if (string.IsNullOrWhiteSpace(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Электромобили")).OrderBy(i => i.Id);
                    carCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("Классические автомобили")).OrderBy(i => i.Id);
                    carCategory = "Классические автомобили";
                }
            }

            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                CurrentCategory = carCategory
            };

            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }
    }
}