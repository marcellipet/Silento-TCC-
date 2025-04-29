using LojaProdutosV2.Models.RequestResponse;
using Microsoft.EntityFrameworkCore;
using Silento.Data;
using Silento.Dto;
using Silento.Models;

namespace Silento.Services.DispositivoAtivacao
{
    public class DispositivoAtivacaoService : IDispositivoAtivacaoInterface
    {
        private readonly AppDbContext _context;
        public DispositivoAtivacaoService(AppDbContext context)
        {
            context = context;
        }

        //public Task<ResponseModel<List<DspDispositivoAtivacao>>> AtualizarAtivacao(DispositivoAtivacaoAtualizarDto dispositivoAtivacaoAtualizarDto)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<ResponseModel<List<DspDispositivoAtivacao>>> BuscarPorAtivacao(long idAtivacao)
        {
            ResponseModel<List<DspDispositivoAtivacao>> resposta = new ResponseModel<List<DspDispositivoAtivacao>>();
            try
            {
                var dispositivosAtivacao = await _context.DspDispositivoAtivacao.Where(d => d.IdEstado.Equals( idAtivacao)).ToListAsync();
                if (dispositivosAtivacao == null || dispositivosAtivacao.Count == 0)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                resposta.Dados = dispositivosAtivacao;
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos encontrados com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
            }
            return resposta;
        }

        public async Task<ResponseModel<List<DspDispositivoAtivacao>>> BuscarPorDispositivo(long idDispositivo)
        {
            ResponseModel<List<DspDispositivoAtivacao>> resposta = new ResponseModel<List<DspDispositivoAtivacao>>();
            try
            {
                var dispositivosAtivacao = await _context.DspDispositivoAtivacao.Where(d => d.IdDispositivo.Equals(idDispositivo)).ToListAsync();

                if (dispositivosAtivacao == null || dispositivosAtivacao.Count == 0)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                resposta.Dados = dispositivosAtivacao;
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos encontrados com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
            }
            return resposta;
        }

        public async Task<ResponseModel<DspDispositivoAtivacao>> BuscarPorId(long id)
        {
            ResponseModel<DspDispositivoAtivacao> resposta = new ResponseModel<DspDispositivoAtivacao>();
            try
            {
                var dispositivoAtivacao = await _context.DspDispositivoAtivacao.FirstOrDefaultAsync(d => d.Id == id);
                if (dispositivoAtivacao == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                resposta.Dados = dispositivoAtivacao;
                resposta.Status = true;
                resposta.Mensagem = "Dispositivo encontrado com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivo: {ex.Message}";
            }
            return resposta;
        }

        public async Task<ResponseModel<bool>> Deletar(long id)
        {
            ResponseModel<bool> resposta = new ResponseModel<bool> ();
            try
            {
                var dispositivoAtivacao = await _context.DspDispositivoAtivacao.FirstOrDefaultAsync(d => d.Id == id);
                if (dispositivoAtivacao == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                _context.DspDispositivoAtivacao.Remove(dispositivoAtivacao);
                _context.SaveChanges();
                resposta.Status = true;
                resposta.Mensagem = "Dispositivo deletado com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao deletar dispositivo: {ex.Message}";
            }
            return resposta;
        }

        public async Task<ResponseModel<List<DspDispositivoAtivacao>>> ListarTodos()
        {
            ResponseModel<List<DspDispositivoAtivacao>> resposta = new ResponseModel<List<DspDispositivoAtivacao>>();
            try
            {
                var dispositivosAtivacao = await _context.DspDispositivoAtivacao.ToListAsync();

                if (dispositivosAtivacao == null || dispositivosAtivacao.Count == 0)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                resposta.Dados = dispositivosAtivacao;
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos encontrados com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
            }
            return resposta;
        }
    }
}
