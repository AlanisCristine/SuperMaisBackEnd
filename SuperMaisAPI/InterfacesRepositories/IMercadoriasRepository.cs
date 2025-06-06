﻿using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface IMercadoriasRepository
    {
        Task Post(Mercadorias mercadoria);
        Task<List<Mercadorias>> Get();
        Task<Mercadorias?> GetById(int id);
        Task Put(Mercadorias mercadoria);
        Task Delete(int id);
    }
}
