using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface IEnderecoRepository
    {
        Task Post(Endereco endereco);
        Task<List<Endereco>> Get();
        Task<Endereco?> GetById(int id);
        Task Put(Endereco endereco);
        Task Delete(int id);
    }
}
