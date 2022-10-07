using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
   public class RentalDetailsDto : IDto
    {
        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string ColourName { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
