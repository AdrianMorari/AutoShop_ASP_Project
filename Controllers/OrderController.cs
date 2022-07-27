using Microsoft.AspNetCore.Mvc;
using TestShop_ASP_Project.Data;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.Data.Models;

namespace TestShop_ASP_Project.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders _allOrders;
        private readonly ShopCart _shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            _allOrders = allOrders;
            _shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shopCart.CartItems = _shopCart.GetCartItems();
            if (_shopCart.CartItems.Count == 0)
            {
                ModelState.AddModelError("", "В корзине нет товаров");
            }

            if (ModelState.IsValid)
            {
                _allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
