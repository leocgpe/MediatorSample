using System.Diagnostics;

namespace ReflectionExamples
{
    public class AlterarPessoaCommand : ICommand<bool>
    {
        private string _nome;
        public AlterarPessoaCommand(string nome, int idade)
        {
            _nome = nome;
            Trace.WriteLine(nome);
        }
    }
}
