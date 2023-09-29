using ImobSystem.Domain.DTO;
using ImobSystem.Domain.Model;
using ImobSystem.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImobSystem.Aplicattion.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ReturnDefault Create(ProdutoCreateDto entrada)
        {
            var objeto = new Produto();
            objeto.Descricao = entrada.Descricao;
            objeto.DataAdd = entrada.DataAdd;
            objeto.Valor = entrada.Valor;
            _produtoRepository.Create(objeto);
            return new ReturnDefault("Criado com sucesso", objeto);
        }

        public ReturnDefault Delete(int id)
        {
            _produtoRepository.Delete(id);
            return new ReturnDefault("Deletado com sucesso", "");
        }

        public async Task<ReturnDefault> GetAll()
        {
            var result =  _produtoRepository.GetAll();
            return new ReturnDefault("Dados retornado com sucesso", result);
        }

        public ReturnDefault GetById(int id)
        {
            var result = _produtoRepository.GetById(id);
            return new ReturnDefault("Dados encontrados com sucesso", result);
        }

        public ReturnDefault Update(ProdutoUpdateDto entrada)
        {
            var resultId = _produtoRepository.GetById(entrada.Id);

            if (!String.IsNullOrEmpty(entrada.Descricao))
            {
                resultId.Descricao = entrada.Descricao;
            }
            if (!String.IsNullOrEmpty(entrada.DataAdd))
            {
                resultId.DataAdd = entrada.DataAdd;
            }
            if (!String.IsNullOrEmpty(entrada.Valor))
            {
                resultId.Valor = entrada.Valor;
            }
            _produtoRepository.Update(resultId);
            return new ReturnDefault("Dados modificados com sucesso", resultId);
        }
    }
}
