using ImobSystem.Domain.DTO;
using ImobSystem.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Infra.Interface
{
    public interface IConteudoService
    {
        ReturnDefault Delete(int id);
        ReturnDefault Update(ResponseConteudoDTO entrada);
        ReturnDefault GetAll();
        ReturnDefault GetById(int id);
        ReturnDefault Create(EntryConteudoDTO entrada);
    }
}
