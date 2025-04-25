using LojaProdutosV2.Models.RequestResponse;
using Silento.Data;
using Silento.Models;

namespace Silento.Services.Dispositivo
{
    public class DispositivoService : IDispositivoInterface
    {
        private readonly AppDbContext _context;
        public DispositivoService(AppDbContext context)
        {
            _context = context;
        }

        public Task<ResponseModel<DspDispositivo>> Atualizar(Guid id, DspDispositivo dispositivo)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DspDispositivo>> BuscarPeloId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DspDispositivo>> BuscarPorEndereco(long idEndereco)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<DspDispositivo>>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DspDispositivo>> Criar(DspDispositivo dispositivo)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<bool>> Deletar(bool StatusDisp)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
