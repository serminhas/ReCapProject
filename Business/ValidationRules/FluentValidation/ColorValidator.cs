using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        { 
        RuleFor(o=>o.ColorName).MinimumLength(5);
            RuleFor(o => o.ColorId).NotEmpty();
            RuleFor(o => o.ColorId).GreaterThan(3);
        }
    }
}
