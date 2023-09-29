using Dapper;
using ImobSystem.Domain.Model;
using ImobSystem.Infra.Interface;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

public class DapperContext
{
    private readonly IConfiguration _config;
    private IDbConnection _connection;

    public DapperContext(IConfiguration config)
    {
        _config = config;
    }

    public IDbConnection Connection
    {
        get
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
            return _connection;
        }
    }

}