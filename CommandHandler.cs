using System.Diagnostics;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    public class CommandHandler : ICommandHandler<CadastrarPessoaCommand, bool>, ICommandHandler<AlterarPessoaCommand, bool>
    {
        public Task<bool> Handle(CadastrarPessoaCommand command)
        {
            Trace.WriteLine($"Handle executando o {command.GetType().Name}");

            return Task.FromResult(true);
        }

        public Task<bool> Handle(AlterarPessoaCommand command)
        {
            Trace.WriteLine($"Handle executando o {command.GetType().Name}");

            return Task.FromResult(true);
        }
    }
}
