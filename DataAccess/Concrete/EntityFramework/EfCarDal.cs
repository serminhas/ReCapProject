using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CBCContext>, ICarDal

    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CBCContext context = new CBCContext())
            {
                var result = from c in context.cars
                             join b in context.brands
                             on c.BrandId equals b.BrandId
                             join o in context.colors
                             on c.ColorId equals o.ColorId
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 BrandId =c.BrandId,
                                 ColorId =o.ColorId
    };
                return result.ToList();
            }
        }
    }
}
