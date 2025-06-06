﻿
using SuperMaisAPI.DTO;
using SuperMaisAPI.Models;
namespace Service.Interfaces;

public interface IMercadoriasService
{
    Task Post(CreateMercadoriasDTO mercadoriaDTO);
    Task<List<Mercadorias>> Get();
    Task<Mercadorias?> GetById(int id);
    Task Put(Mercadorias mercadoria);
    Task Delete(int id);
}