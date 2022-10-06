using Business.Abstract;
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

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _BrandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Marka ismi için en az 2 karaker girilmeli.");
            }
        }

        public List<Brand> GetAll()
        {
            return _BrandDal.GetAll();
        }
    }
}
