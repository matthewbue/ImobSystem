using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Domain.DTO
{
  public class EntryConteudoDTO
  {
    public string? Descricao { get; set; }
    public byte[]? Imagem { get; set; }
    public string? TipoPage { get; set; }
    public string? TipoConteudo { get; set; }
  }
}