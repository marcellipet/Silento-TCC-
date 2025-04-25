using LojaProdutosV2.Models.RequestResponse;
using Silento.Models;

namespace Silento.Services.Dispositivo
{
    public interface IDispositivoInterface
    {
        public Task<ResponseModel<List<DspDispositivo>>> BuscarTodos();
        public Task<ResponseModel<DspDispositivo>> BuscarPeloId(Guid id);
        public Task<ResponseModel<DspDispositivo>> BuscarPorEndereco(long idEndereco, EndEndereco endEndereco);
        public Task<ResponseModel<DspDispositivo>> BuscarPorIp(string idIp);
        public Task<ResponseModel<DspDispositivo>> BuscarPorStatus(bool status);
        public Task<ResponseModel<DspDispositivo>> BuscarPorAtivacao(int id, AtvAtivacaoEstado atvAtivacaoEstado);
        public Task<ResponseModel<DspDispositivo>> Criar(DspDispositivo dispositivo);
        public Task<ResponseModel<DspDispositivo>> Atualizar(Guid id, DspDispositivo dispositivo);
        public Task<ResponseModel<bool>> Deletar(bool StatusDisp);

    }
}
