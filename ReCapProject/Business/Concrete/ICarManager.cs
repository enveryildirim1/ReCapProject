using Business.Abtract;
using DataAccess.Abtract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ICarManager : ICarServis
    {
        ICarDal _CarDal;

        public ICarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }
    }
}
