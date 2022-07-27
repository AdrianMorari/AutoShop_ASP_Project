using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestShop_ASP_Project.Data.Interfaces;
using TestShop_ASP_Project.Data.Models;

namespace TestShop_ASP_Project.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                   
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
