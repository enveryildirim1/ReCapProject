using Entities.Abtract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class ColorCar : IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
