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
                string sql = "INSERT INTO Conteudo (Descricao, Imagem, TipoPage, TipoConteudo, DataAdc) " +
                                "VALUES (@Descricao, @Imagem, @TipoPage, @TipoConteudo, @DataAdc)";

                _connection.Execute(sql, modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM Conteudo WHERE ID = @ID";

            _connection.Execute(sql, new { ID = id });
        }

        public IEnumerable<Conteudo> GetAll()
        {
            return _connection.Query<Conteudo>("SELECT * FROM Conteudo");
        }

        public Conteudo GetById(int id)
        {
            return _connection.QueryFirstOrDefault<Conteudo>("SELECT * FROM Conteudo WHERE Id = @Id", new { Id = id });
        }
    }
}