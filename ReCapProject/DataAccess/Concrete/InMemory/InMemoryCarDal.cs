using DataAccess.Abtract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="1981",DailyPrice=50,Description="mercedes benz 1981 model w123 siyah"},
                new Car{CarId=2,BrandId=2,ColorId=2,ModelYear="2010",DailyPrice=100,Description="Renault  2010 model Megan-4 beyaz"},
                new Car{CarId=3,BrandId=1,ColorId=3,ModelYear="2022",DailyPrice=100,Description="mercedes benz  2022 model EQE kırmızı"},
            };
            
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAllByBrand(int brandıd)
        {
            return _car.Where(p => p.BrandId == brandıd).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
