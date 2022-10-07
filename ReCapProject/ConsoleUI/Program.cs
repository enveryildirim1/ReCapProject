using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          

            ICarManager carManager = new ICarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Seccess == true)
            {

                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.CarName + "/" + product.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}

