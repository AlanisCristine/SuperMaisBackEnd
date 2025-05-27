using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface ITabelaComprasRepository
    {
        Task Post(TabelaCompras tabelaCompras);
        Task<List<TabelaCompras>> Get();
        Task<TabelaCompras?> GetById(int id);
        Task Put(TabelaCompras tabelaCompras);
        Task Delete(int id);

    }
}
