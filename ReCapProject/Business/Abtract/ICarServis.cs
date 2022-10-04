using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abtract
{
  public  interface ICarServis
    {
        List<Car> GetAll();
    }
}
