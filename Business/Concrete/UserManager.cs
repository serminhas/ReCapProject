using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            //if (!user.Email.Contains("@"))
            //{
            //    return new ErrorResult("Geçersiz mail adresi yüzünden kullanıcı eklenemedi");
            //}
            //ValidationTool.Validate(new UserValidator(), user);
            return new SuccessResult(Messages.UserAdded);
            _userDal.Add(user);
        }

        public IResult Delete(User user)
        {
            //try
            //{
            //    _userDal.Delete(user);
            //    return new SuccessResult(Messages.UserDeleted);
            //}
            //catch (Exception)
            //{
            //    return new ErrorResult("Geçersiz mail adresi yüzünden kullanıcı silinemedi");
            //}
            //ValidationTool.Validate(new UserValidator(), user);
                _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == Id));
        }

        public IResult Update(User user)
        {
            //if (!user.Email.Contains("@"))
            //{
            //    return new ErrorResult("Geçersiz mail adresi yüzünden kullanıcı güncellenemedi");
            //}
            //ValidationTool.Validate(new UserValidator(), user);
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
