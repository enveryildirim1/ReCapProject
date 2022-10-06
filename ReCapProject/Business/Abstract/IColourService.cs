﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IColourService
    {
        List<Colour> GetAll();
        void Add(Colour brand);
    }
}