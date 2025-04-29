using LojaProdutosV2.Models.RequestResponse;
using Microsoft.AspNetCore.Mvc;
using Silento.Models;
using Silento.Services.DispositivoAtivacao;

namespace Silento.Controllers
{
    public class DispositivoAtivacaoController : Controller
    {
        private readonly IDispositivoAtivacaoInterface dispositivoAtivacaoInterface;
        public DispositivoAtivacaoController(IDispositivoAtivacaoInterface dispositivoAtivacaoInterface)
        {
            this.dispositivoAtivacaoInterface = dispositivoAtivacaoInterface;
        }

        [HttpGet("ListarTodos")]
        public async Task<ResponseModel<List<DspDispositivoAtivacao>>> ListarTodos()
        {
            var resposta = await dispositivoAtivacaoInterface.ListarTodos();
            return resposta;
        }

        [HttpGet("{id}BuscarPorId")]
        public async Task<ResponseModel<DspDispositivoAtivacao>> BuscarPorId(long id)
        {
            var resposta = await dispositivoAtivacaoInterface.BuscarPorId(id);
            return resposta;
        }

        [HttpGet("{id}BuscarPorAtivacao")]
        public async Task<ResponseModel<List<DspDispositivoAtivacao>>> BuscarPorAtivacao(long idAtivacao)
        {
            var resposta = await dispositivoAtivacaoInterface.BuscarPorAtivacao(idAtivacao);
            return resposta;
        }

        [HttpGet("{id}BuscarPorDispositivo")]
        public async Task<ResponseModel<List<DspDispositivoAtivacao>>> BuscarPorDispositivo(long idDispositivo)
        {
            var resposta = await dispositivoAtivacaoInterface.BuscarPorDispositivo(idDispositivo);
            return resposta;
        }

        //[HttpPut("AtualizarAtivacao")]
    }
}
