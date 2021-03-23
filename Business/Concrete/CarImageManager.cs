using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileOperations;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _imageDal;
        
        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        //[SecuredOperation("admin, car.add")]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfImgLimitExceded(carImage.CarId));
            if(result != null)
            {
                return result;
            }
            carImage.UploadDate = DateTime.Now;
            carImage.ImagePath = FileOperation.Add(file);
            var data = carImage.ImagePath.Split('\\').LastOrDefault();
            carImage.ImagePath = "/images/" + data;
            _imageDal.Add(carImage);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            string targetFolder = Directory.GetCurrentDirectory().ToString() + @"\Uploads\CarImages";
            string targetFile = _imageDal.Get(i => i.Id == carImage.Id).ImagePath;
            var targetPath = Path.GetFullPath(Path.Combine(targetFolder,targetFile));
            var result = FileOperation.Delete(targetPath);
            _imageDal.Delete(carImage);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IResult Update(IFormFile file, int carImageId)
        {
            CarImage carImage = _imageDal.Get(i => i.Id == carImageId);
            IResult result = BusinessRules.Run(CheckIfImgLimitExceded(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            
            carImage.UploadDate = DateTime.Now;
            carImage.ImagePath = FileOperation.Update(carImage.ImagePath, file);
            _imageDal.Update(carImage);
            return new SuccessResult(Messages.ImageUpdated);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(), Messages.ImagesListed);
        }

        public IDataResult<List<CarImage>> GetAllImgsOfCarById(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(c=>c.CarId == carId), Messages.ImagesListed);
        }

        public IDataResult<CarImage> GetByImgId(int carImageId)
        {
            return new SuccessDataResult<CarImage>(_imageDal.Get(c => c.Id == carImageId));
        }

        private IResult CheckIfImgLimitExceded(int carId)
        {
            var result = _imageDal.GetAll(c => c.CarId == carId).Count;
            if(result >= 5)
            {
                return new ErrorResult(Messages.ImageLimitExceded);
            }
            return new SuccessResult();
        }

        
    }
}
