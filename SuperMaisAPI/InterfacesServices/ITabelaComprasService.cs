
using SuperMaisAPI.DTO;
using SuperMaisAPI.Models;
namespace Service.Interfaces;

public interface ITabelaComprasService
{
    Task Post(CreateTabelaComprasDTO tabelaComprasDTO);
    Task<List<TabelaCompras>> Get();
    Task<TabelaCompras?> GetById(int id);
    Task Put(TabelaCompras tabelaCompras);
    Task Delete(int id);
}