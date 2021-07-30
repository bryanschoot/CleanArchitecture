using CleanArchitecture.Application.Project.Dtos;
using CleanArchitecture.Shared.Mediator;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Project.Queries
{
    public record GetProjectsQuery : IQuery<IEnumerable<ProjectDto>>;
}
