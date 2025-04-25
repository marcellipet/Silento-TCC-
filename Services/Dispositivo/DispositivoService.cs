using LojaProdutosV2.Models.RequestResponse;
using Microsoft.EntityFrameworkCore;
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

        public Task<ResponseModel<List<DspDispositivo>>> AtualizarDec(Guid id, DspDispositivo dispositivo, DspDispositivoAtivacao dspDispositivoAtivacao)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DspDispositivo>> BuscarPeloId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<DspDispositivo>>> BuscarPorAtivacao(int id, AtvAtivacaoEstado atvAtivacaoEstado)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DspDispositivo>> BuscarPorEndereco(long idEndereco, EndEndereco endEndereco)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<DspDispositivo>> BuscarPorIp(string idIp)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<DspDispositivo>>> BuscarPorStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<DspDispositivo>>> BuscarTodos()
        {
            
            ResponseModel<List<DspDispositivo>> resposta = new ResponseModel<List<DspDispositivo>>();
            try
            {
                // verifica se o banco de dados está acessível
                var dispositivos = await _context.DspDispositivo.ToListAsync();

                // verifica se a lista de dispositivos está vazia ou nula
                if (dispositivos == null || dispositivos.Count == 0)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }

                // verifica se a lista de dispositivos contém elementos
                resposta.Dados = dispositivos;
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos encontrados com sucesso.";
            }
            // trata exceções 
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
            }
            return resposta;

        }

        public Task<ResponseModel<DspDispositivo>> Criar(DspDispositivo dispositivo)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<bool>>> Deletar(bool StatusDisp)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
