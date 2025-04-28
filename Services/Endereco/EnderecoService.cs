using LojaProdutosV2.Models.RequestResponse;
using Microsoft.EntityFrameworkCore;
using Silento.Data;
using Silento.Models;

namespace Silento.Services.Endereco
{
    public class EnderecoService : IEnderecoInterface
    {
        private readonly AppDbContext _context;
        public EnderecoService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Task<ResponseModel<EndEndereco>> BuscarDispPorEnde(long idDispositivo)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<EndEndereco>> BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<bool>> Deletar(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<EndEndereco>>> ListarTodos()
        {
            ResponseModel<List<EndEndereco>> resposta = new ResponseModel<List<EndEndereco>>();
            try
            {
                var enderecos = _context.EndEndereco.ToListAsync();
                if (enderecos == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum endereço encontrado.";
                    return resposta;
                }
                resposta.Dados = enderecos.Result;
                resposta.Status = true;
                resposta.Mensagem = "Endereços encontrados com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar endereços: {ex.Message}";
            }
            return resposta;
        }
    }
}
