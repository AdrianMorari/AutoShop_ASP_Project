using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.Data.Models;

namespace TestShop_ASP_Project.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly ShopCart _shopCart;

        public OrderRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDBContent.Order.Add(order);

            var items = _shopCart.CartItems;

            foreach (var item in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarId = item.Car.Id,
                    OrderId = order.Id,
                    Price = item.Car.Price
                };
                _appDBContent.OrderDetail.Add(orderDetail);
            }
            _appDBContent.SaveChanges();
        }
    }
}
