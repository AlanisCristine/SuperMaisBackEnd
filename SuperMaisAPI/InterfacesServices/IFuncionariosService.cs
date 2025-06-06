﻿
using SuperMaisAPI.DTO;
using SuperMaisAPI.Models;

namespace Service.Interfaces;

public interface IFuncionariosService
{
    Task Post(CreateFuncionariosDTO funcionarioDTO);
    Task<List<Funcionarios>> Get();
    Task<Funcionarios?> GetById(int id);
    Task Put(Funcionarios funcionario);
    Task Delete(int id);
}