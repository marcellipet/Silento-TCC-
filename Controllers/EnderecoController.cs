using LojaProdutosV2.Models.RequestResponse;
using Microsoft.AspNetCore.Mvc;
using Silento.Models;
using Silento.Services.Endereco;

namespace Silento.Controllers
{
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoInterface enderecoInterface;
        public EnderecoController(IEnderecoInterface enderecoInterface)
        {
            this.enderecoInterface = enderecoInterface;
        }

        [HttpGet("ListarTodos")]
        public async Task<ResponseModel<List<EndEndereco>>> ListarTodos()
        {
            var resposta = await enderecoInterface.ListarTodos();
            return resposta;
        }

        [HttpGet("{id}/BuscarPorId")]
        public async Task<ResponseModel<EndEndereco>> BuscarPorId(long id)
        {
            var resposta = await enderecoInterface.BuscarPorId(id);
            return resposta;
        }

        [HttpGet("{idEndereco}/BuscarDispPorEnde")]
        public async Task<ResponseModel<List<EndEndereco>>> BuscarDispPorEnde(long idDispositivo)
        {
            var resposta = await enderecoInterface.BuscarDispPorEnde(idDispositivo);
            return resposta;
        }

        [HttpGet("BuscarEnderecoPorEstado")]
        public async Task<ResponseModel<List<EndEndereco>>> BuscarEnderecoPorEstado(char Estado)
        {
            var resposta = await enderecoInterface.BuscarEnderecoPorEstado(Estado);
            return resposta;
        }

        [HttpDelete("Deletar")]
        public async Task<ResponseModel<bool>> Deletar(long id)
        {
            var resposta = await enderecoInterface.Deletar(id);
            return resposta;
        }
    }
}
