using CleanArchitecture.Application.Project.Dtos;
using CleanArchitecture.Shared.Mediator;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Project.Queries
{
    public class GetProjectByIdQueryHandler : IQueryHandler<GetProjectByIdQuery, ProjectDto>
    {
        public async Task<ProjectDto> Handle(GetProjectByIdQuery request, CancellationToken cancellationToken)
        {
            return new ProjectDto { Id = request.Id };
        }
    }
}
