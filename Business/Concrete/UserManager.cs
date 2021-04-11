using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Business;
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
        public IResult Add(User user)
        {
            IResult result = BusinessRules.Run(CheckSameMail(user.Email));
            if(result != null)
            {
                return result;
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == Id));
        }

        public IResult Update(User user)
        {
            user.Status = true;
            user.PasswordHash = _userDal.Get(u => u.UserId == user.UserId).PasswordHash;
            user.PasswordSalt = _userDal.Get(u => u.UserId == user.UserId).PasswordSalt;
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IDataResult<User> GetUserDetailByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(m => m.Email == email));
        }

        private IResult CheckSameMail(string email)
        {
            var result = _userDal.GetAll(e => e.Email == email).Count;
            if (result >= 1)
            {
                return new ErrorResult(Messages.SameEmail);
            }
            return new SuccessResult();
        }
    }
}
