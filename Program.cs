using System.Diagnostics;

namespace ReflectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new AlterarPessoaCommand("Leandro", 32);

            var mediator = new Mediator();
            var response = mediator.Send(command);

            Trace.WriteLine($"O comando {command.GetType().Name} foi processado com sucesso? {(response.Result?"Sim":"Não")}");
        }
    }
}
