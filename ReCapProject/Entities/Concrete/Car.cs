﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Car : IEntity
    {
        public int CarId { get; set; }
        public int ColourId { get; set; }
        public int BrandId{ get; set; }
        public string CarName{ get; set; }
        public string ModelYear { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
