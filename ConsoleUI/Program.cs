using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryMode;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
            Console.ReadLine();

            //***********adding a car**********//
            //EfCarDal efCarDal = new EfCarDal();
            //Car car1 = new Car()
            //{
            //    BrandId = 3,
            //    CarName = "BMW 320i",
            //    DailyPrice = 108500,
            //    ModelYear = "1999",
            //    ColorId = 2,
            //    Description = "Nice BMW Car"
            //};
            //efCarDal.Add(car1);
            //delete, update etc. will be like this
        }
    }
}
