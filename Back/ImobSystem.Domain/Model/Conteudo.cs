namespace ImobSystem.Domain.Model
{
  public class Conteudo
  {
    public int ID { get; set; }
    public string? Descricao { get; set; }
    public byte[]? Imagem { get; set; }
    public string? TipoPage { get; set; }
    public string? TipoConteudo { get; set; }
    public DateTime DataAdc { get; set; }
  }
}