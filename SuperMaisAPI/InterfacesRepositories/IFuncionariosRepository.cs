using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface IFuncionariosRepository
    {
        Task Post(Funcionarios funcionario);
        Task<List<Funcionarios>> Get();
        Task<Funcionarios?> GetById(int id);
       /* Task<Endereco?> ObterEnderecoPorIdAsync(int enderecoId);*/
        Task Put(Funcionarios funcionario);
        Task Delete(int id);
    }
}
