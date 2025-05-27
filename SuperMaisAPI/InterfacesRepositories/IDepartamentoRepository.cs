using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{

    public interface IDepartamentoRepository
    {
        Task Post(Departamento departamento);
        Task<List<Departamento>> Get();
        Task<Departamento?> GetByDepartamentoId(int id);
        Task<Departamento?> GetByEnderecoId(int id);
        Task Put(Departamento departamento);
        Task DeleteByDepartamentoId(int id);
        Task DeleteByEnderecoId(int id);
    }
}
