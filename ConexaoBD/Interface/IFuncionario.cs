using ConexaoBD.Models;

namespace ConexaoBD.Interface
{
    internal interface IFuncionario
    {
        void Create(Funcionario funcionario);

        void Update(Funcionario funcionario);

        void Delete(Funcionario funcionario);
    }
}
