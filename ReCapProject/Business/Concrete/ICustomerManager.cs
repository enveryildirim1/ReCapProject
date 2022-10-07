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
    public class ICustomerManager : ICustomerService
    {
        ICustomerDal _CustomerDal;
        public ICustomerManager(ICustomerDal customerDal)
        {
            _CustomerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _CustomerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _CustomerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_CustomerDal.GetAll());
        }

        public IDataResult<Customer> GetbyId(int customerId)
        {
            return new SuccessDataResult<Customer>(_CustomerDal.Get(p => p.CustomerId == customerId));
        }

        public IResult Update(Customer customer)
        {
            _CustomerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
