using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Domain.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string DataAdd { get; set;}
        public string Valor { get; set;}
    }
}
