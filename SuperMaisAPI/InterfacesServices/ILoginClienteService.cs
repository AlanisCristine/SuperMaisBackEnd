
using SuperMaisAPI.DTO;
using SuperMaisAPI.Models;

namespace Service.Interfaces;

public interface ILoginclienteService
{
    Task Post(CreateLoginclienteDTO loginClienteDTO);
    Task<List<Logincliente>> Get();
    Task<Logincliente?> GetById(int id);
    Task Put(Logincliente loginCliente);
    Task Delete(int id);
}