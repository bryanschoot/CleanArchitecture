using FluentValidation;

namespace CleanArchitecture.Application.Project.Queries
{
    public class GetProjectByIdQueryValidator : AbstractValidator<GetProjectByIdQuery>
    {
        public GetProjectByIdQueryValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty()
                .NotNull()
                .Equal(20);
        }
    }
}
