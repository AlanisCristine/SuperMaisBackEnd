﻿
using SuperMaisAPI.DTO;
using SuperMaisAPI.Models;
namespace Service.Interfaces;

public interface IEnderecoService
{
    Task Post(CreateEnderecoDTO enderecoDTO);
    Task<List<Endereco>> Get();
    Task<Endereco?> GetById(int id);
    Task Put(Endereco endereco);
    Task Delete(int id);
}