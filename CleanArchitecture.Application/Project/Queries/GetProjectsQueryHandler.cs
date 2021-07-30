using CleanArchitecture.Application.Project.Dtos;
using CleanArchitecture.Shared.Mediator;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Project.Queries
{
    class GetProjectsQueryHandler : IQueryHandler<GetProjectsQuery, IEnumerable<ProjectDto>>
    {
        public async Task<IEnumerable<ProjectDto>> Handle(GetProjectsQuery request, CancellationToken cancellationToken)
        {
            var projects = new List<ProjectDto>
            {
                new ProjectDto()
                {
                    Id = 1,
                    Name = "Coding project",
                    Description = "Learning clean architecture"
                }
            };

            return projects;
        }
    }
}
