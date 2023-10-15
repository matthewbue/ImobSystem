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
    public class ConteudoService : IConteudoService
    {
        private readonly IConteudoRepository _ConteudoRepository;
        public ConteudoService(IConteudoRepository ConteudoRepository)
        {
            _ConteudoRepository = ConteudoRepository;
        }

        public ReturnDefault Create(EntryConteudoDTO entrada)
        {
            var objeto = new Conteudo();
            objeto.Descricao = entrada.Descricao;
            objeto.Imagem = entrada.Imagem;
            objeto.TipoPage = entrada.TipoPage;
            objeto.TipoConteudo = entrada.TipoConteudo;
            objeto.DataAdc = DateTime.Now;
            _ConteudoRepository.Create(objeto);
            return new ReturnDefault("Criado com sucesso", objeto);
        }

        public ReturnDefault Delete(int id)
        {
            //_ConteudoRepository.Delete(id);
            return new ReturnDefault("Deletado com sucesso", "");
        }

        public ReturnDefault GetAll()
        {
            //var result =  _ConteudoRepository.GetAll();
            return new ReturnDefault("Dados retornado com sucesso", "");
        }

        public ReturnDefault GetById(int id)
        {
            var result = _ConteudoRepository.GetById(id);
            return new ReturnDefault("Dados encontrados com sucesso", result);
        }

        public ReturnDefault Update(ResponseConteudoDTO entrada)
        {
            //var resultId = _ConteudoRepository.GetById(entrada.Id);

            //if (!String.IsNullOrEmpty(entrada.Descricao))
            //{
            //    resultId.TipoConteudo = entrada.Descricao;
            //}
            //if (!String.IsNullOrEmpty(entrada.DataAdd))
            //{
            //    resultId.Imagem = entrada.DataAdd;
            //}
            //if (!String.IsNullOrEmpty(entrada.Valor))
            //{
            //    resultId.TipoPage = entrada.Valor;
            //}
            //_ConteudoRepository.Update(resultId);
            return new ReturnDefault("Dados modificados com sucesso", "");
        }
    }
}
