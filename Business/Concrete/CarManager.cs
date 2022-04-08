using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba başarıyla eklenmiştir");
            }
            else
            {
                Console.WriteLine("Araba eklemede hata oldu, lütfen verilen kurallara uyunuz.!!!");
            }
            
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {

            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p=>p.BrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
