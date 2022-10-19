using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidation : AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(p => p.CarName).MaximumLength(2);
            RuleFor(p => p.CarName).NotEmpty();

            RuleFor(p => p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
        }
    }
}
