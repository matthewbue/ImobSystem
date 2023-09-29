using ImobSystem.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Infra.Interface
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        void Delete(int id);
        void Update(Produto modelo);
        Produto GetById(int id);
        void Create(Produto modelo);
    }
}
