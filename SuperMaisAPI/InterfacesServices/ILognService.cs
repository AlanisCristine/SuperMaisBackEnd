
using SuperMaisAPI.DTO;
using SuperMaisAPI.Models;
namespace Service.Interfaces;

public interface ILognService
{
    Task Post(CreateLognDTO lognDTO);
    Task<List<Logn>> Get();
    Task<Logn?> GetById(int id);
    Task Put(Logn logn);
    Task Delete(int id);
}