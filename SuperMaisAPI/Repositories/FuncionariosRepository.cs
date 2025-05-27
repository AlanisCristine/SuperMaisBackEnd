
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using SuperMaisAPI.DTO;
using SuperMaisAPI.InterfacesRepositories;
using SuperMaisAPI.Models;
using System.Data;

namespace DAO.Repositories;

public class FuncionariosRepository : IFuncionariosRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public FuncionariosRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Funcionarios funcionario)
    {
        using var db = _connection;

        await db.InsertAsync(funcionario);
    }

    public async Task<List<Funcionarios>> Get()
    {
        using var db = _connection;

        var funcionarios = await db.GetAllAsync<Funcionarios>();

        return funcionarios.ToList();
    }

    public async Task<Funcionarios?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Funcionarios>(id);
    }


    /*public async Task<List<FuncionarioComEnderecoDTO>> GetComEndereco()
    {
        using var db = _connection;

        var funcionarios = await db.GetAllAsync<Funcionarios>();
        var lista = new List<FuncionarioComEnderecoDTO>();

        foreach (var f in funcionarios)
        {
            var endereco = await db.GetAsync<Endereco>(f.EnderecoId);

            if (endereco == null) continue;

            lista.Add(new FuncionarioComEnderecoDTO
            {
                IdFuncionarios = f.idFuncionarios,
                NomeFuncionario = f.NomeFuncionario,
                CPFFuncionario = f.CPFFuncionario,
                DataNascimento = f.DataNascimento,
                DataContrato = f.DataContrato,
                DataDemissao = f.DataDemissao,
                TelefoneFuncionario = f.TelefoneFuncionario,
                CelularFuncionario = f.CelularFuncionario,
                EnderecoId = f.EnderecoId,
                Endereco = new EnderecoDTO
                {
                    Id = endereco.Id,
                    Rua = endereco.Rua,
                    Numero = endereco.Numero,
                    Bairro = endereco.Bairro,
                    Cidade = endereco.Cidade,
                    UF = endereco.UF,
                    CEP = endereco.CEP,
                    Complemento = endereco.Complemento
                }
            });
        }

        return lista;
    }*/

    public async Task Put(Funcionarios funcionario)
    {
        using var db = _connection;

        await db.UpdateAsync(funcionario);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var funcionario = await GetById(id);

        if (funcionario != null) await db.DeleteAsync(funcionario);
    }
}