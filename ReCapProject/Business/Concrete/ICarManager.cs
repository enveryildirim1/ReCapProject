using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class ICarManager : ICarService
    {
        ICarDal _CarDal;

        public ICarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length >= 2)
            {
                _CarDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _CarDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetAllByColourId(int colourId)
        {
            return _CarDal.GetAll(c => c.ColourId == colourId);
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }
    }
}
