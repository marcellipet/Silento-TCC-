using LojaProdutosV2.Models.RequestResponse;
using Silento.Models;

namespace Silento.Services.Endereco
{
    public interface IEnderecoInterface
    {
        Task<ResponseModel<List<EndEndereco>>> ListarTodos();
        Task<ResponseModel<EndEndereco>> BuscarPorId(long id);
        Task<ResponseModel<List<EndEndereco>>> BuscarDispPorEnde(long idDispositivo);
        Task<ResponseModel<List<EndEndereco>>> BuscarEnderecoPorEstado(char Estado);

        //Task<ResponseModel<EndEndereco>> Criar(EndEndereco endereco); tenho que ver como que faz ainda
        Task<ResponseModel<bool>> Deletar(long id);
    }
}
