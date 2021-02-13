using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                /*
                 new Car{Id= 1, BrandId="A", ColorId="SilverGrey", DailyPrice=1000000, Description="AstonMartin", ModelYear=2021},
                new Car{Id= 2, BrandId="A", ColorId="RainBlue", DailyPrice=2000000, Description="Porsche", ModelYear=2020},
                new Car{Id= 3, BrandId="A", ColorId="HellRed", DailyPrice=1500000, Description="Ferrari", ModelYear=2021}
                 */
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {


            //LINQ olmadan
            /*Car carToDelete = null;
             * foreach(var c in _cars)
            {
                if(car.Id==c.Id)
                {
                    carToDelete=c;
                }
            }
            _cars.Remove(carToDelete); */

            //LINQ ile;
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCatDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId     = car.BrandId;
            carToUpdate.ColorId     = car.ColorId;
            carToUpdate.DailyPrice  = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id          = car.Id;
            carToUpdate.ModelYear   = car.ModelYear;
        }
    }
}
