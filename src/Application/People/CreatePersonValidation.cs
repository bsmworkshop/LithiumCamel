using FluentValidation;

namespace LithiumCamel.Application.People
{
    public class CreatePersonValidation : AbstractValidator<CreatePersonCommand>
    {
        public CreatePersonValidation()
        {
            RuleFor(command => command.FamilyName)
                .NotEmpty()
                .MinimumLength(2);

            RuleFor(command => command.GivenName)
                .NotEmpty()
                .MinimumLength(2);
        }
    }
}
