using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandIdTest();
            //ColorIdTest();
            //Add();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine(car.Description + "/" + car.BrandId);
            }

        }

       /*private static void Add()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 22, DailyPrice = 3000000, ModelYear = 2021, Description = "SiyahAstonMartin" });
        }

        private static CarManager ColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                System.Console.WriteLine(car.Description);
            }

            return carManager;
        }

        private static CarManager BrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                System.Console.WriteLine(car.Description);
            }

            return carManager;
        }*/
    }
}
