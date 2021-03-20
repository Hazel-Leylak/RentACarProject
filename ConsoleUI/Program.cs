using Business.Concrete;
using Core.Entities.Concrete;
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
            CarTest();
            //CategoryTest();
            //AddCar();
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //AddCustomer();
            //AddUser();
            AddRent();
            Console.ReadLine();
        }

        private static void AddRent()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //DateTime date = new DateTime(2021, 2, 16);
            rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate =new DateTime(2021,2,23)
                //ReturnDate = new DateTime(0001,01,01)

            });
        }

        private static void AddUser()
        {
            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User
            //{
            //    FirstName = "Arthur",
            //    LastName = "Morgan",
            //    Email = "arthurmorgan@blackwater.com",
            //    Password = "arthurm"
            //});
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
               
                UserId = 1,
                CompanyName = "SaintDeni Company"
            });
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 265000,
                Description = "Diesel&Manual",
                ModelYear = "2016",
                CarName = "Audi A3"
            });
        }

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var category in brandManager.GetAll())
        //    {
        //        Console.WriteLine(category.CategoryName);
        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAllCarsDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "  /  " + car.BrandName + " / " + car.ColorName+" / " + car.DailyPrice + "TL" );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
