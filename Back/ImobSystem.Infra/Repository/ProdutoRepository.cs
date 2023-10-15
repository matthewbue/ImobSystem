using Dapper;
using ImobSystem.Domain.Model;
using ImobSystem.Infra.Interface;
using System.Data;

namespace ImobSystem.Infra.Repository
{
  public class ConteudoRepository : IConteudoRepository
  {
    private readonly IDbConnection _connection;

    public ConteudoRepository(IDbConnection connection)
    {
      _connection = connection;
    }

    public void Create(Conteudo modelo)
    {
      try
      {
        _connection.Execute("INSERT INTO Conteudos ( Descricao, DataAdd, Valor) VALUES ( @Descricao, @DataAdd, @Valor)", modelo);
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    public IEnumerable<Conteudo> GetAll()
    {
      return _connection.Query<Conteudo>("SELECT * FROM Conteudos");
    }

    public Conteudo GetById(int id)
    {
      return _connection.QueryFirstOrDefault<Conteudo>("SELECT * FROM Conteudos WHERE Id = @Id", new { Id = id });
    }

  }
}