using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.Data.Models;
using TestShop_ASP_Project.ViewModels;

namespace TestShop_ASP_Project.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRepository = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetCartItems();
            _shopCart.CartItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRepository.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
