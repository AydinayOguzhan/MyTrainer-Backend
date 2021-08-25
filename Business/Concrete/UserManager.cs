using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(BaseUser user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(BaseUser user)
        {
            _userDal.Add(user);
        }

        public BaseUser GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
