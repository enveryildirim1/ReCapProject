using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.Concrete;
using System.Collections.Generic;
using User = Core.Entities.Concrete.User;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}