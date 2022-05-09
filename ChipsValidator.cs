using FluentValidation;
using WebApplication7.Models;

namespace WebApplication7
{
    public class ChipsValidator : AbstractValidator<Chips>
    {
        public ChipsValidator()
        {
            RuleFor(c => c.Name).NotEmpty().NotNull();
            RuleFor(c => c.Price).NotEmpty().NotNull();
            RuleFor(c => c.Avalibility).NotEmpty().NotNull();
            RuleFor(c => c.ExpDate).NotEmpty().NotNull();
            RuleFor(c => c.HealthV).NotEmpty().NotNull();



        }
    }
}
