using LojaProdutosV2.Models.RequestResponse;
using Microsoft.AspNetCore.Mvc;
using Silento.Dto;
using Silento.Models;
using Silento.Services.AtivacaoEstado;

namespace Silento.Controllers
{
    public class AtivacaoEstadoController : ControllerBase
    {
        private readonly IAtivacaoEstadoInterface _ativacaoEstadoService;
        public AtivacaoEstadoController(IAtivacaoEstadoInterface ativacaoEstadoService)
        {
            _ativacaoEstadoService = ativacaoEstadoService;
        }

        [HttpGet("BuscarTodos")]
        public async Task<ResponseModel<List<AtvAtivacaoEstado>>> BuscarTodos()
        {
            var resposta = await _ativacaoEstadoService.BuscarTodos();
            return resposta;
        }

        [HttpPost("CriarEstado")]
        public async Task<ResponseModel<AtvAtivacaoEstado>> CriarEstado([FromBody] AtvAtivacaoEstado ativacaoEstado)
        {
            var resposta = await _ativacaoEstadoService.CriarEstado(ativacaoEstado);
            return resposta;
        }

        [HttpPut("AtualizarEstado")]
        public async Task<ResponseModel<List<AtvAtivacaoEstado>>> AtualizarEstado([FromBody] AtivacaoAtualizarDto ativacaoAtualizarDto)
        {
            var resposta = await _ativacaoEstadoService.AtualizarEstado(ativacaoAtualizarDto);
            return resposta;
        }
    }
}
