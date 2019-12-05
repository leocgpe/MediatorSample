using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    public class Mediator
    {
        public Task<TResponse> Send<TResponse>(ICommand<TResponse> command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            Type requestType = command.GetType();
            Type responseType = typeof(TResponse);

            Type commandHandlerType = requestType.Assembly.DefinedTypes
                .Where(x => x.ImplementedInterfaces.Contains(typeof(ICommandHandler<, >).MakeGenericType(requestType, responseType)))
                .FirstOrDefault();

            var commandHandler = Activator.CreateInstance(commandHandlerType, null);

            MethodInfo methodInfo = commandHandlerType.GetMethod("Handle", new Type[]{ requestType });

            return methodInfo.Invoke(commandHandler, new object[] { command }) as Task<TResponse>;
        }
    }
}
