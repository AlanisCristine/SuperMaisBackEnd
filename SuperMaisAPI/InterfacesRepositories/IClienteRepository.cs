using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface IClienteRepository
    {
        Task Post(Cliente cliente);
        Task<List<Cliente>> Get();
        Task<Cliente?> GetByCPF(int cpf);
        Task Put(Cliente cliente);
        Task Delete(int cpf);
    }
}
