using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetAllImgsOfCarById(int carId);
        //IDataResult<List<CarImage>> GetImgsByBrandId(int id);
        //IDataResult<List<CarImage>> GetImgsByColorId(int id);
        IDataResult<CarImage> GetByImgId(int carImageId);
        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, int carImageId);
    }
}
