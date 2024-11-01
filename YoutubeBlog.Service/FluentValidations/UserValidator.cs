using FluentValidation;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.FluentValidations
{
    public class UserValidator : AbstractValidator<AppUser>
    {

        public UserValidator()
        {
            RuleFor(x => x.FirstName)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .MaximumLength(150)
            .WithName("Name");

            RuleFor(x => x.LastName)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .MaximumLength(150)
            .WithName("Last Name");

            RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .NotNull()
            .MinimumLength(11)
            .WithName("Phone Number");
        }
    }
}
