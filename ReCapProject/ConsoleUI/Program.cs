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
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
        }
    }
}

