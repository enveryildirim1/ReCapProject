using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColourId=1,CarName="W123",ModelYear="1981",DailyPrice=50,Description="mercedes benz 1981 model w123 siyah"},
                new Car{CarId=2,BrandId=2,ColourId=2,CarName="Megan-4",ModelYear="2010",DailyPrice=100,Description="Renault  2010 model Megan-4 beyaz"},
                new Car{CarId=3,BrandId=1,ColourId=3,CarName="EQE",ModelYear="2022",DailyPrice=100,Description="mercedes benz  2022 model EQE kırmızı"},
            };

        }
        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == entity.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
