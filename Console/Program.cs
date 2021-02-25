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
            //GetCarDetails();
             UserManager userManager = new UserManager(new EfUserDal());
             var result = userManager.Add(new User 
             { Id = 1, FirstName = "Onur", LastName = "Has", Email = "oh@gmail.com", Password = 123 });
            System.Console.WriteLine(result.Message);

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result1 = rentalManager.Add(new Rental
            {Id=1, CarId = 2, CustomerId = 1, RentDate = new DateTime(2021, 2, 23), ReturnDate = new DateTime(2021, 2, 27)}); System.Console.WriteLine(result1.Message);

        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
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
