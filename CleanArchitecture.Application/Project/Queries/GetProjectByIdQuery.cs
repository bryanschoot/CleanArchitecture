using CleanArchitecture.Application.Project.Dtos;
using CleanArchitecture.Shared.Mediator;

namespace CleanArchitecture.Application.Project.Queries
{
    public record GetProjectByIdQuery(int Id) : IQuery<ProjectDto>;

}
