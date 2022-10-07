using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IBrandManager : IBrandService
    {
        IBrandDal _BrandDal;

        public IBrandManager(IBrandDal brandDal)
        {
            _BrandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName!.Length < 2)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            else
            {
                _BrandDal.Add(brand);
            }
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _BrandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_BrandDal.GetAll());
        }

        public IDataResult<Brand> GetbyId(int brandId)
        {
            return new SuccessDataResult<Brand>(_BrandDal.Get(p => p.BrandId == brandId));
        }

        public IResult Update(Brand brand)
        {
            _BrandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
