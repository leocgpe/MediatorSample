using System.Threading.Tasks;

namespace ReflectionExamples
{
    public interface ICommandHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
    {
        Task<TResponse> Handle(TCommand command);
    }
}
