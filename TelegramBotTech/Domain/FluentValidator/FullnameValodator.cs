using Domain.Primitives;
using Domain.ValueObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.FluentValidator
{
    public class FullnameValodator : AbstractValidator<FullName>
    {
        public FullnameValodator()
        {
                     RuleFor(x => x.FirstName)
         .NotNull().WithMessage(Validationessages.NotNull(nameof(FullName)))
          .NotEmpty().WithMessage(Validationessages.NotEmpty(nameof(FullName)))
          .Matches(@"^[a-zA-Zа-яА-Я]+$")
          .WithMessage(Validationessages.InvalidProperty(nameof(FullName)));

        }
    }
}
