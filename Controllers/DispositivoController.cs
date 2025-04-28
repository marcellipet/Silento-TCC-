using LojaProdutosV2.Models.RequestResponse;
using Microsoft.AspNetCore.Mvc;
using Silento.Models;
using Silento.Services.Dispositivo;

namespace Silento.Controllers
{
    public class DispositivoController : ControllerBase
    {
        private readonly IDispositivoInterface _dispositivoService;
        public DispositivoController(IDispositivoInterface dispositivoService)
        {
            _dispositivoService = dispositivoService;
        }

        [HttpGet("BuscarTodos")]
        public async Task<ResponseModel<List<DspDispositivo>>> GetAll()
        {
            var todos = await _dispositivoService.BuscarTodos();
            return todos;
        }

        [HttpGet("{id}/BuscarPeloId")]
        public async Task<ResponseModel<DspDispositivo>> BuscarPeloId(Guid id)
        {
            var dispId = await _dispositivoService.BuscarPeloId(id);
            return dispId;
        }

        [HttpGet("{idIp}/BuscarPorIp")]
        public async Task<ResponseModel<DspDispositivo>> BuscarPorIp(string idIp)
        {
            var dispId = await _dispositivoService.BuscarPorIp(idIp);
            return dispId;
        }

        [HttpGet("{status}/BuscarPorStatus")]
        public async Task<ResponseModel<List<DspDispositivo>>> BuscarPorStatus(bool status)
        {
            var dispId = await _dispositivoService.BuscarPorStatus(status);
            return dispId;
        }

        //[HttpGet("{id}/BuscarPorAtivacao")]
        //public async Task<ResponseModel<List<DspDispositivo>>> BuscarPorAtivacao(int id, [FromBody] AtvAtivacaoEstado atvAtivacaoEstado)
        //{
        //    var dispId = await _dispositivoService.BuscarPorAtivacao(id, atvAtivacaoEstado);
        //    return dispId;
        //}

        [HttpPost("Criar")]
        public async Task<ResponseModel<DspDispositivo>> Criar([FromBody] DspDispositivo dispositivo)
        {
            var dispId = await _dispositivoService.Criar(dispositivo);
            return dispId;
        }

        [HttpDelete("{bool}/Deletar")]
        public async Task<ResponseModel<List<bool>>> Deletar(bool StatusDisp)
        {
            var dispId = await _dispositivoService.Deletar(StatusDisp);
            return dispId;
        }
    }
}
