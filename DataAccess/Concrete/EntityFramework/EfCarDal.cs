using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext reCapContext= new ReCapContext())
            {
                var result = from car in reCapContext.Cars
                             join color in reCapContext.Colors on car.ColorId equals color.ColorId
                             join brand in reCapContext.Brands on car.BrandId equals brand.BrandId

                             select new CarDetailDto
                             {
                                 CarName = car.Description,
                                 ColorName = color.ColorName,
                                 BrandName = brand.BrandName,
                                 DailyPrice = car.DailyPrice,
                             };

                return result.ToList();
                            

            }
        }
    }
}
