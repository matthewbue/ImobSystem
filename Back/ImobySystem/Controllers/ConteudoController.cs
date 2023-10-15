using ImobSystem.Domain.DTO;
using ImobSystem.Infra.Interface;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ConteudoController : ControllerBase
{
    private readonly IConteudoService _conteudoService;

    public ConteudoController(IConteudoService conteudoService)
    {
        _conteudoService = conteudoService ?? throw new ArgumentNullException(nameof(conteudoService));
    }

    [HttpPost("Create")]
    public IActionResult Create([FromBody] EntryConteudoDTO entrada)
    {
        try
        {
            var result = _conteudoService.Create(entrada);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest("Ocorreu um erro durante a criação do conteúdo.");
        }
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        try
        {
            var result = _conteudoService.GetAll();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest("Ocorreu um erro ao buscar todos os conteúdos.");
        }
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById(int id)
    {
        try
        {
            var result = _conteudoService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound($"Conteúdo com ID {id} não encontrado.");
            }
        }
        catch (Exception ex)
        {
            return BadRequest("Ocorreu um erro ao buscar o conteúdo por ID.");
        }
    }

    [HttpDelete("Delete/{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            var result = _conteudoService.Delete(id);

            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest("Ocorreu um erro ao excluir o conteúdo.");
        }
    }

    [HttpPut("Update")]
    public IActionResult Update([FromBody] ResponseConteudoDTO entrada)
    {
        try
        {
            var result = _conteudoService.Update(entrada);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest("Ocorreu um erro durante a atualização do conteúdo.");
        }
    }
}