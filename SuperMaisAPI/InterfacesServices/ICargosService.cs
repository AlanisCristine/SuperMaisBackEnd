
using SuperMaisAPI.DTO;
using SuperMaisAPI.Models;

namespace Service.Interfaces;

public interface ICargosService
{
    Task Post(CreateCargosDTO cargoDTO);
    Task<List<Cargos>> Get();
    Task<Cargos?> GetById(int id);
    Task Put(Cargos cargo);
    Task Delete(int id);
}