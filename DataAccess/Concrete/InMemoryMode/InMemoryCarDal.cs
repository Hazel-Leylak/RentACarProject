using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryMode
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=2,CarName="Hyundai i20",DailyPrice=220000,Description="**informations**",ModelYear="2020"},
                new Car{CarId=1,BrandId=2,ColorId=2,CarName="Honda Civic",DailyPrice=264000,Description="**informations**",ModelYear="2021"},
                new Car{CarId=1,BrandId=3,ColorId=2,CarName="Peugeot 308",DailyPrice=133500,Description="**informations**",ModelYear="2014"},
                new Car{CarId=1,BrandId=4,ColorId=2,CarName="BMW 320i",DailyPrice=108500,Description="**informations**",ModelYear="1999"},
                new Car{CarId=1,BrandId=4,ColorId=2,CarName="BMW 418i Gran Coupe Prestige",DailyPrice=354000,Description="**informations**",ModelYear="2015"},
                new Car{CarId=1,BrandId=5,ColorId=2,CarName="Mercedes Benz C 200 d BlueTEC Exclusive ",DailyPrice=482000,Description="**informations**",ModelYear="2017"},
                new Car{CarId=1,BrandId=6,ColorId=2,CarName="Honda Accord 2.0 ES",DailyPrice=47900,Description="**informations**",ModelYear="1997"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carsToDelete);
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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
