using LojaProdutosV2.Models.RequestResponse;
using Silento.Dto;
using Silento.Models;

namespace Silento.Services.DispositivoAtivacao
{
    public interface IDispositivoAtivacaoInterface
    {
        Task<ResponseModel<List<DspDispositivoAtivacao>>> ListarTodos();
        Task<ResponseModel<DspDispositivoAtivacao>> BuscarPorId(long id);
        Task<ResponseModel<List<DspDispositivoAtivacao>>> BuscarPorAtivacao(long idAtivacao);
        Task<ResponseModel<List<DspDispositivoAtivacao>>> BuscarPorDispositivo(long idDispositivo);
        Task<ResponseModel<List<DspDispositivoAtivacao>>> AtualizarAtivacao(DispositivoAtivacaoAtualizarDto dispositivoAtivacaoAtualizarDto);
        Task<ResponseModel<bool>> Deletar(long id);
    }
}
