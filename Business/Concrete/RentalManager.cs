using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {

           
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.rentalAddedMessage);
        }


        public IResult Delete(Rental rental)
        {
           _rentalDal.Delete(rental);
            return new SuccessResult(Messages.rentalDeletedMessage);
        }


        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.rentalListed);
        }


        public IDataResult<Rental> GetByCarId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.CarId==id),Messages.rentalGetByCarId);
        }


        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id),Messages.rentalGetById);
        }

        public IDataResult<List<RentalDetailDto>> GetDetails()
        {
            var result = _rentalDal.GetDetails();
            return new SuccessDataResult<List<RentalDetailDto>>(result, Messages.rentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.rentalUpdatedMessage);
        }
    }
}
