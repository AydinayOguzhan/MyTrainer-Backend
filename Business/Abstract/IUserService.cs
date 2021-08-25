using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(BaseUser user);
        void Add(BaseUser user);
        BaseUser GetByMail(string email);
    }
}
