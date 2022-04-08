using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2020",DailyPrice=500,Description="Otomatik Vites"},
            new Car{Id=2,BrandId=2,ColorId=2,ModelYear="2022",DailyPrice=700,Description="0 KM"},
            new Car{Id=3,BrandId=3,ColorId=3,ModelYear="2019",DailyPrice=450,Description="Dizel "},
            new Car{Id=4,BrandId=4,ColorId=4,ModelYear="2016",DailyPrice=300,Description="Benzinli"},
            new Car{Id=5,BrandId=5,ColorId=5,ModelYear="2014",DailyPrice=250,Description="Ağır Hasar Kayıtlı"},
            new Car{Id=6,BrandId=6,ColorId=6,ModelYear="2009",DailyPrice=180,Description="Manuel Vites"},

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
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

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id==id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(ctu=>ctu.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

       // Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        //{
         //   throw new NotImplementedException();
        //}
    }
}
