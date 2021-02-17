using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        //IDataResult<List<Rental>> GetCarsByBrandId(int id);
        //IDataResult<List<Rental>> GetCarsByColorId(int id);
        IDataResult<List<Rental>> GetByDateRange(DateTime from, DateTime to);
        IDataResult<List<Rental>> GetByCarId(int carId);
        IDataResult<Rental> GetById(int Id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IResult CheckReturn(int carId);
        IResult AddReturnDate(int rentalId);
    }
}
