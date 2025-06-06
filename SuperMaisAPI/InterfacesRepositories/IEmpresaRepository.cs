﻿using SuperMaisAPI.Models;

namespace SuperMaisAPI.InterfacesRepositories
{
    public interface IEmpresaRepository
    {
        Task Post(Empresa empresa);
        Task<List<Empresa>> Get();
        Task<Empresa?> GetByCNPJ(string cnpj);
        Task Put(Empresa empresa);
        Task Delete(string cnpj);
    }
}
