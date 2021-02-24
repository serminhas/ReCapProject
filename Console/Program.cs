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
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                   System.Console.WriteLine(car.Description + "/" + car.BrandId + "/" + car.ColorId + "/" + car.DailyPrice);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }      

        }

       private static void Add()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 22, DailyPrice = 3000000, ModelYear = 2021, Description = "SiyahAstonMartin" });
        }

        private static CarManager ColorIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(2).Data)
            {
                System.Console.WriteLine(car.Description);
            }

            return carManager;
        }

        private static CarManager BrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2).Data)
            {
                System.Console.WriteLine(car.Description);
            }

            return carManager;
        }
    }
}
