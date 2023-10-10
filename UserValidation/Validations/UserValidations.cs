using FluentValidation;
using UserValidation.Entities;
using System;

namespace UserValidation.Validations
{
    public class UserValidations : AbstractValidator<User>
    {
        public UserValidations()
        {
            RuleFor(x => x.IdUser)
             .NotNull()
             .GreaterThan(0);


            RuleFor(x => x.FirstName)
            .NotEmpty()
            .Length(3, 10);


            RuleFor(x => x.Surname)
            .NotEmpty()
            .Length(3, 50);


            RuleFor(x => x.Email)
            .NotEmpty();
          

            RuleFor(x => x.Cell)
           .NotEmpty()
           .Length(11);

        }



    }
}
