using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> GetCars{
            get{
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla",
                        ShortDesc = "",
                        LongDesc = "",
                        Img = "/img/TESLA.jpg",
                        Price = 45000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCaterories.First()
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/ford-fiesta-st.jpg",
                        Price = 11000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCaterories.Last()
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/bmw M3.jpg",
                        Price = 65000,
                        IsFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCaterories.Last()
                    }

                };
            }
        }

        private IEnumerable<Car> getFavCars1;

        public IEnumerable<Car> GetFavCars()
        {
            return getFavCars1;
        }

        public void SetgetFavCars(IEnumerable<Car> value)
        {
            getFavCars1 = value;
        }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
