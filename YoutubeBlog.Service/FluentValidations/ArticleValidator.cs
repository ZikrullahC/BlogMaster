using FluentValidation;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.FluentValidations
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
                RuleFor(x => x.Title)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(3)
                    .MaximumLength(150)
                    .WithName("Title");

                RuleFor(x => x.Content)
                    .NotEmpty()
                    .NotNull()
                    .MinimumLength(150)
                    .MaximumLength(100000)
                    .WithName("Content");
        }
    }
}
