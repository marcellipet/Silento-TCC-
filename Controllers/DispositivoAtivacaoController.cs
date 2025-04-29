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
    }
}
