using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {

		IDataResult<List<Car>> GetAll();
		IDataResult<List<Car>> GetAllByBrandId(int brandId);
		IDataResult<List<Car>> GetAllByColourId(int colourId);
		IDataResult<List<CarDetailsDto>> GetCarDetails();
		IResult Add(Car car);
		IResult Delete(Car car);
		IResult Update(Car car);
		IResult AddTransactionalTest(Car car);
	}
}
