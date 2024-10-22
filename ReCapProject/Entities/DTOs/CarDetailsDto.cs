﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class CarDetailsDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string ColourName { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
