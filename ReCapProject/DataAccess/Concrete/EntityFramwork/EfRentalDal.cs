using Core.DataAccess.EntityFramwork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
   public class EfRentalDal : IEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
    }
}
