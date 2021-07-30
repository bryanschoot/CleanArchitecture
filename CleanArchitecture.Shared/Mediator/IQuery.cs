using MediatR;

namespace CleanArchitecture.Shared.Mediator
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
