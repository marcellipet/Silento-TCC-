using LojaProdutosV2.Models.RequestResponse;
using Microsoft.EntityFrameworkCore;
using Silento.Data;
using Silento.Dto;
using Silento.Models;

namespace Silento.Services.AtivacaoEstado
{
    public class AtivacaoEstadoService : IAtivacaoEstadoInterface
    {
        private readonly AppDbContext _context;

        public AtivacaoEstadoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<List<AtvAtivacaoEstado>>> AtualizarEstado(AtivacaoAtualizarDto ativacaoAtualizarDto)
        {
            ResponseModel<List<AtvAtivacaoEstado>> resposta = new ResponseModel<List<AtvAtivacaoEstado>>();

            try
            {
                var ativacaoEstado = _context.AtvAtivacaoEstado.FirstOrDefault(a => a.Id == ativacaoAtualizarDto.Id);
                if (ativacaoEstado == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                resposta.Dados = new List<AtvAtivacaoEstado> { ativacaoEstado };
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos encontrados com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
                return resposta;
            }
            return resposta;
        }

        public async Task<ResponseModel<List<AtvAtivacaoEstado>>> BuscarTodos()
        {
            ResponseModel<List<AtvAtivacaoEstado>> resposta = new ResponseModel<List<AtvAtivacaoEstado>>();
            try
            {
                var ativacaoEstado = _context.AtvAtivacaoEstado.ToListAsync();
                if (ativacaoEstado == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                resposta.Dados = ativacaoEstado.Result;
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

        public async Task<ResponseModel<AtvAtivacaoEstado>> CriarEstado(AtvAtivacaoEstado ativacaoEstado)
        {
            ResponseModel<AtvAtivacaoEstado> resposta = new ResponseModel<AtvAtivacaoEstado>();
            try
            {
                await _context.AtvAtivacaoEstado.AddAsync(ativacaoEstado);
                await _context.SaveChangesAsync();

                resposta.Status = true;
                resposta.Mensagem = "Ativação criada com sucesso.";
                resposta.Dados = ativacaoEstado;
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao criar ativação: {ex.Message}";
            }
            return resposta;
        }
    }
}
