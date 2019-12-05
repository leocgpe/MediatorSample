using System.Diagnostics;

namespace ReflectionExamples
{
    public class CadastrarPessoaCommand : ICommand<bool>
    {
        private string _nome;
        public CadastrarPessoaCommand(string nome, int idade)
        {
            _nome = nome;
            Trace.WriteLine(nome);
        }
    }
}
