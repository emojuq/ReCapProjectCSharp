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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetDetails(Expression<Func<Rental, bool>> filter = null)
        {

            using (ReCapContext context = new ReCapContext())
            {
                var result = from rental in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join car in context.Cars
                             on rental.CarId equals car.Id
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             join user in context.Users
                             on customer.UserId equals user.Id
                             select new RentalDetailDto { Id = rental.Id,CarId=rental.CarId, BrandName = brand.BrandName, FullName = $"{user.FirstName} {user.LastName}", RentDate = rental.RentDate, ReturnDate = rental.ReturnDate };
                return result.ToList();

            }

        }
        //public List<RentalDetailDto> GetDetails()
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {

        //        var result = from rental in context.Rentals
        //                     join c in context.Cars
        //                     on rental.CarId equals c.Id
        //                     join brand in context.Brands
        //                    on c.BrandId equals brand.BrandId
        //                     join customer in context.Customers
        //                    on rental.CustomerId equals customer.Id
        //                     join user in context.Users
        //                    on customer.Id equals user.Id
        //                     select new RentalDetailDto { Id = rental.Id, BrandName = brand.BrandName, FullName = $"{user.FirstName} {user.LastName}", RentDate = rental.RentDate, ReturnDate = rental.ReturnDate };
        //               return result.ToList();

        //    }
        //}
    }
}