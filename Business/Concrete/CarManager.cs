using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.carAddedMessage);
            }
            else
            {
                
                return new ErrorResult(Messages.carNameInvalid);

            }
            
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.carDeletedMessage);
        }

        public IDataResult<List<Car>> GetAll()
        {

            if (DateTime.Now.Hour == 17) //eğer saat 17 ise sistem bakımda error mesajı verir,değilse success olur
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.carListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.carDetailsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==brandId),Messages.carListedByBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId),Messages.carListedByColorId);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.carUpdatedMessage);
        }
    }
}
