
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using SuperMaisAPI.InterfacesRepositories;
using SuperMaisAPI.Models;
using System.Data;

namespace DAO.Repositories;

public class LoginclienteRepository : ILoginclienteRepository
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;

    public LoginclienteRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("DefaultConnection");
    }

    private IDbConnection _connection => new MySqlConnection(_connectionString);

    public async Task Post(Logincliente loginCliente)
    {
        using var db = _connection;

        await db.InsertAsync(loginCliente);
    }

    public async Task<List<Logincliente>> Get()
    {
        using var db = _connection;

        var loginsCliente = await db.GetAllAsync<Logincliente>();

        return loginsCliente.ToList();
    }

    public async Task<Logincliente?> GetById(int id)
    {
        using var db = _connection;

        return await db.GetAsync<Logincliente>(id);
    }

    public async Task Put(Logincliente loginCliente)
    {
        using var db = _connection;

        await db.UpdateAsync(loginCliente);
    }

    public async Task Delete(int id)
    {
        using var db = _connection;

        var loginCliente = await GetById(id);

        if (loginCliente != null) await db.DeleteAsync(loginCliente);
    }
}