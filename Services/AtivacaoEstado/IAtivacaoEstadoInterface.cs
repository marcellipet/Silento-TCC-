using LojaProdutosV2.Models.RequestResponse;
using Silento.Dto;
using Silento.Models;

namespace Silento.Services.AtivacaoEstado
{
    public interface IAtivacaoEstadoInterface
    {
        public Task<ResponseModel<List<AtvAtivacaoEstado>>> BuscarTodos();
        public Task<ResponseModel<List<AtvAtivacaoEstado>>> AtualizarEstado(AtivacaoAtualizarDto ativacaoAtualizarDto);
        public Task<ResponseModel<AtvAtivacaoEstado>> CriarEstado(AtvAtivacaoEstado ativacaoEstado);
        //public Task<ResponseModel<List<AtvAtivacaoEstado>>> BuscarDispPorAtivacao(Guid idDispositivo);
    }
}
