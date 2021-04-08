using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        //[SecuredOperation("admin, car.add")]
        public IResult Add(Color carColor)
        {
            _colorDal.Add(carColor);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color carColor)
        {
            _colorDal.Delete(carColor);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            if(DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Color>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.ColorsListed);
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }

        public IResult Update(Color carColor)
        {
            if(DateTime.Now.Hour == 3)
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
            _colorDal.Update(carColor);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
