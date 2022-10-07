using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IUserManager : IUserService
    {
        IUserDal _UserDal;
        public IUserManager(IUserDal userDal)
        {
            _UserDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName!.Length < 2 || user.LastName!.Length<2)
            {
                return new ErrorResult(Messages.UserNameInvalid);
            }
            else
            {
                _UserDal.Add(user);
            }
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _UserDal.Delete(user);
             return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_UserDal.GetAll());
        }

        public IDataResult<User> GetbyId(int userId)
        {
            return new SuccessDataResult<User>(_UserDal.Get(p => p.UserId == userId));
        }

        public IResult Update(User user)
        {
            _UserDal.Update(user);
            return new SuccessResult();
        }
    }
}
