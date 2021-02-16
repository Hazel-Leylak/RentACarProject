using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (RentACarContext context = new RentACarContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars on re.CarId equals ca.CarId
                             join cu in context.Customers on re.CustomerId equals cu.Id
                             join us in context.Users on cu.UserId equals us.UserId
                             join br in context.Brands on ca.BrandId equals br.BrandId
                             select new RentalDetailDto
                             {
                                 RentalId = re.Id,
                                 CarId = ca.CarId,
                                 CarName = ca.CarName,
                                 BrandName = br.BrandName,
                                 CustomerName = cu.CompanyName,
                                 UserName = us.FirstName + " " + us.LastName,
                                 RentalDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,

                             };

                return result.ToList();

            }
        }


    }
}
