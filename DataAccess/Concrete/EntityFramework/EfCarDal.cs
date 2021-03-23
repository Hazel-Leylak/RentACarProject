using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using(RentACarContext context = new RentACarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 CarId = car.CarId,
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 BrandId = brand.BrandId,
                                 DailyPrice = car.DailyPrice,
                                 ColorName = color.ColorName,
                                 ColorId = color.ColorId,
                                 modelYear = car.ModelYear,
                                 Description = car.Description                                 
                             };

                if (filter == null)
                    return result.ToList();
                else
                    return result.Where(filter).ToList();
            }
        }

        
    }
}
