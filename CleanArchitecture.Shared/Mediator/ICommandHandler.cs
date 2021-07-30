using MediatR;

namespace CleanArchitecture.Shared.Mediator
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Unit>
         where TCommand : ICommand
    {
    }
}
