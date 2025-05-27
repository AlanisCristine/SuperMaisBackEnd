using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface ILognRepository
    {
        Task Post(Logn logn);
        Task<List<Logn>> Get();
        Task<Logn?> GetById(int id);
        Task Put(Logn logn);
        Task Delete(int id);
    }
}
