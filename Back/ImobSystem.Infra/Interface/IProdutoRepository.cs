using ImobSystem.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Infra.Interface
{
    public interface IConteudoRepository
    {
        //IEnumerable<Conteudo> GetAll();
        //void Delete(int id);
        //void Update(Conteudo modelo);
        Conteudo GetById(int id);
        void Create(Conteudo modelo);
    }
}
