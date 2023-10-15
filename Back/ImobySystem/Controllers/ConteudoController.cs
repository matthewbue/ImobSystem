using ImobSystem.Domain.DTO;
using ImobSystem.Infra.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ImobySystem.Controllers
{
    public class ConteudoController : ControllerBase
    {
        private readonly IConteudoService _ConteudoService;
        public ConteudoController(IConteudoService ConteudoService)
        {
            _ConteudoService = ConteudoService;
        }
        [HttpPost("Create")]
        public IActionResult Create([FromBody]EntryConteudoDTO entrada)
        {
            var result = _ConteudoService.Create(entrada);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _ConteudoService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _ConteudoService.GetById(id);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _ConteudoService.Delete(id);
            return Ok(result);
        }
        [HttpPut("Update")]
        public IActionResult Update(ResponseConteudoDTO entrada)
        {
            var result = _ConteudoService.Update(entrada);
            return Ok(result);
        }
    }
}
