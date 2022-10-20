using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarImageValidation : AbstractValidator<CarImage>
    {
        public CarImageValidation()
        {
            RuleFor(p => p.CarImageId).NotEmpty();
            RuleFor(p => p.CarId).NotEmpty();
        }
    }
}
