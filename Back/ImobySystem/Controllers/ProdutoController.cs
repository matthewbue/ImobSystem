using ImobSystem.Domain.DTO;
using ImobSystem.Infra.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ImobySystem.Controllers
{
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpPost("Create")]
        public IActionResult Create([FromBody]ProdutoCreateDto entrada)
        {
            var result = _produtoService.Create(entrada);
            return Ok(result);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _produtoService.GetAll();
            return Ok(result);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _produtoService.GetById(id);
            return Ok(result);
        }
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _produtoService.Delete(id);
            return Ok(result);
        }
        [HttpPut("Update")]
        public IActionResult Update(ProdutoUpdateDto entrada)
        {
            var result = _produtoService.Update(entrada);
            return Ok(result);
        }
    }
}
