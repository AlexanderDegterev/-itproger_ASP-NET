using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> GetCars { get; }

        IEnumerable<Car> GetFavCars();
        void SetgetFavCars(IEnumerable<Car> value);
        Car getObjectCar(int carId);

    }
}
