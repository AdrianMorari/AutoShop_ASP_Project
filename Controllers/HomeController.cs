using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.ViewModels;

namespace TestShop_ASP_Project.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRepository;
        public HomeController(IAllCars allCars)
        {
            _carRepository = allCars;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                FavoriteCars = _carRepository.GetFavCars
            };
            return View(homeCars);
        }
    }
}
