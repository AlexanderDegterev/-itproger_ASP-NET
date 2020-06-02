using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller    /*Controller - using Microsoft.AspNetCore.Mvc;*/
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List() {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.GetCars;
            obj.currCategory = "Автомобили";

            return View(obj);
        
            /*ViewBag.Category = "Some New";
            var cars = _allCars.GetCars; /*интерфейс - функция Cars
            return View(cars);*/
        }
    }
}
