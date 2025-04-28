using LojaProdutosV2.Models.RequestResponse;
using Silento.Models;

namespace Silento.Services.Dispositivo
{
    public interface IDispositivoInterface
    {
        public Task<ResponseModel<List<DspDispositivo>>> BuscarTodos();
        public Task<ResponseModel<DspDispositivo>> BuscarPeloId(Guid id);
        //public Task<ResponseModel<DspDispositivo>> BuscarPorEndereco(long idEndereco);
        public Task<ResponseModel<DspDispositivo>> BuscarPorIp(string idIp);
        public Task<ResponseModel<List<DspDispositivo>>> BuscarPorStatus(bool status);
        //public Task<ResponseModel<List<DspDispositivo>>> BuscarPorAtivacao(int idAtvEstado);
        public Task<ResponseModel<DspDispositivo>> Criar(DspDispositivo dispositivo);
        public Task<ResponseModel<List<DspDispositivo>>> AtualizarDec(Guid id, DspDispositivo dispositivo, DspDispositivoAtivacao dspDispositivoAtivacao );
        public Task<ResponseModel<List<bool>>> Deletar(bool StatusDisp);

    }
}
