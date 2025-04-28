using LojaProdutosV2.Models.RequestResponse;
using Silento.Models;

namespace Silento.Services.Endereco
{
    public interface IEnderecoInterface
    {
        Task<ResponseModel<List<EndEndereco>>> ListarTodos();
        Task<ResponseModel<EndEndereco>> BuscarPorId(long id);
        Task<ResponseModel<EndEndereco>> BuscarDispPorEnde(long idDispositivo);
        Task<ResponseModel<bool>> Deletar(long id);
    }
}
