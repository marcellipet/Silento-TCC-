using LojaProdutosV2.Models.RequestResponse;
using Silento.Models;

namespace Silento.Services.DispositivoAtivacao
{
    public interface IDispositivoAtivacaoInterface
    {
        Task<ResponseModel<List<DspDispositivoAtivacao>>> ListarTodos();
        Task<ResponseModel<DspDispositivoAtivacao>> BuscarPorId(long id);
        Task<ResponseModel<List<DspDispositivoAtivacao>>> BuscarDispPorAtivacao(long idAtivacao);
        Task<ResponseModel<List<DspDispositivoAtivacao>>> AtualizarAtivacao(DispositivoAtivacaoDto dispositivoAtivacaoDto);
        Task<ResponseModel<bool>> Deletar(long id);
    }
}
