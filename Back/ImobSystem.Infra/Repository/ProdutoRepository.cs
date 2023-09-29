using Dapper;
using ImobSystem.Domain.Model;
using ImobSystem.Infra.Context;
using ImobSystem.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Infra.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IDbConnection _connection;
        public ProdutoRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Create(Produto modelo)
        {
             _connection.Execute("INSERT INTO Produtos ( Descricao, DataAdd, Valor) VALUES ( @Descricao, @DataAdd, @Valor)", modelo);
        }

        public void Delete(int id)
        {
            _connection.Execute("DELETE FROM Produtos WHERE Id = @Id", new { Id = id });
        }

        public IEnumerable<Produto> GetAll()
        {
            return _connection.Query<Produto>("SELECT * FROM Produtos");
        }

        public Produto GetById(int id)
        {
            return _connection.QueryFirstOrDefault<Produto>("SELECT * FROM Produtos WHERE Id = @Id", new { Id = id });
        }

        public void Update(Produto modelo)
        {
            _connection.Execute("UPDATE Produtos SET Nome = @Nome, Preco = @Preco WHERE Id = @Id", modelo);
        }
    }
}
