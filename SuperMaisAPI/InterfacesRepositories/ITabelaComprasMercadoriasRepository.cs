using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface ITabelaComprasMercadoriasRepository
    {
        Task Post(TabelaComprasMercadorias tabelaComprasMercadorias);
        Task<List<TabelaComprasMercadorias>> Get();
        Task<TabelaComprasMercadorias?> GetById(int id);
        Task Put(TabelaComprasMercadorias tabelaComprasMercadorias);
        Task Delete(int id);
    }
}
