using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
      
		List<Car> GetAll();
		List<Car> GetAllByBrandId(int brandId);
		List<Car> GetAllByColourId(int colourId);
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);
	}
}
