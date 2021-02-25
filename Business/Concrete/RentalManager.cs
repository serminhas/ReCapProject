﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate!=null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            return new ErrorResult("Araç kiralama başarısız");
           
        }

        public IResult Delete(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.RentalDeleted);
            }
            return new ErrorResult("Araç kiralama silinemedi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int Id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id==Id));
        }

        public IResult Update(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.RentalUpdated);
            }
            return new ErrorResult("Araç kiralama güncellenemedi");
        }
    }
}