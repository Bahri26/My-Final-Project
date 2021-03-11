using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using Business.Constants;
using ConsoleTables;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ConsoleUI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //CarTest();
            //UserTest();
            //ColorTest();
            //RentalManager();
            //CustomerTest();
            Console.ReadLine();
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();

            if (result.Success)
            {
                foreach (var data in result.Data)
                {
                    Console.WriteLine(data.CompanyName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalManager()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAllRentalDetail();

            if (result.Success)
            {
                foreach (var data in result.Data)
                {
                    Console.WriteLine(data.CarBrand + "/" + data.CarModel + "/" + data.CompanyName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success)
            {
                foreach (var data in result.Data)
                {
                    Console.WriteLine(data.Name);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();

            if (result.Success)
            {
                foreach (var data in result.Data)
                {
                    Console.WriteLine(data);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var data in result.Data)
                {
                    Console.WriteLine("Araba : " + data.BrandName + " / " + "Günlük fiyat : " + data.DailyPrice + " / " + "Açıklama : " + data.Description);
                }

            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success)
            {
                foreach (var data in result.Data)
                {
                    Console.WriteLine(data.Name);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }

}
