using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,CarContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Car on rental.CarId equals car.Id
                    join user in context.User on rental.UserId equals user.Id
                    join customer in context.Customer on rental.CustomerId equals customer.Id
                    join brand in context.Brands on car.BrandId equals brand.Id
                    select new RentalDetailDto
                    {
                        CarId = rental.CarId,
                        CarDescription = car.Description,
                        CarBrand = brand.Name,
                        CarModel = car.ModelYear,
                        CompanyName = customer.CompanyName,
                        CustomerFirstName = user.FirstName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate
                    };
                return result.ToList();
            }
        }
    }
}
