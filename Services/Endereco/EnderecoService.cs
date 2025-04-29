using LojaProdutosV2.Models.RequestResponse;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<ResponseModel<List<EndEndereco>>> BuscarDispPorEnde(long idDispositivo)
        {
            ResponseModel<List<EndEndereco>> resposta = new ResponseModel<List<EndEndereco>>();
            try
            {
                var enderecos = _context.EndEndereco.Where(e => e.Id == idDispositivo).ToListAsync();
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

        public async Task<ResponseModel<List<EndEndereco>>> BuscarEnderecoPorEstado(char Estado)
        {
            ResponseModel<List<EndEndereco>> resposta = new ResponseModel<List<EndEndereco>>();
            try
            {
                var enderecos = await _context.EndEndereco.Where(e => e.Estado == Estado).ToListAsync();
                if (enderecos == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum endereço encontrado.";
                    return resposta;
                }
                resposta.Dados = enderecos;
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

        public async Task<ResponseModel<EndEndereco>> BuscarPorId(long id)
        {
            ResponseModel<EndEndereco> resposta = new ResponseModel<EndEndereco>();
            try
            {
                var endereco = await _context.EndEndereco.FirstOrDefaultAsync(e => e.Id == id);
                
                if (endereco == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum endereço encontrado.";
                    return resposta;
                }
            }
            catch (Exception ex) 
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar endereço: {ex.Message}";

            }
                return resposta;
            }

        //public Task<ResponseModel<EndEndereco>> Criar(EndEndereco endereco)
        //{
        //    throw new NotImplementedException();
        //}
        public async Task<ResponseModel<bool>> Deletar(long id)
        {
            ResponseModel<bool> resposta = new ResponseModel<bool>();
            try
            {
                var endereco = await _context.EndEndereco.FindAsync(id);
                if (endereco == null)
                {
                    resposta.Mensagem = "Endereço não encontrado.";
                    resposta.Status = false;
                    return resposta;
                }

                _context.EndEndereco.Remove(endereco);
                await _context.SaveChangesAsync();
                resposta.Mensagem = "Endereço deletado com sucesso.";
                resposta.Status = true;
                return resposta;

            }
            catch (Exception ex) 
            {
                resposta.Mensagem = $"Erro ao buscar endereço: {ex.Message}";
                resposta.Status = false;    
            }
            return resposta;
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

        //public async Task<ResponseModel<List<EndEndereco>>> BuscarDispPorEnde(long idDispositivo)
        //{
        //    ResponseModel<List<EndEndereco>> resposta = new ResponseModel<List<EndEndereco>>();
        //    try
        //    {
        //        var enderecos = _context.EndEndereco.Where(e => e.Id == idDispositivo).ToListAsync();
        //        if (enderecos == null)
        //        {
        //            resposta.Status = false;
        //            resposta.Mensagem = "Nenhum endereço encontrado.";
        //            return resposta;
        //        }
        //        resposta.Dados = enderecos.Result;
        //        resposta.Status = true;
        //        resposta.Mensagem = "Endereços encontrados com sucesso.";
        //    }
        //    catch (Exception ex)
        //    {
        //        resposta.Status = false;
        //        resposta.Mensagem = $"Erro ao buscar endereços: {ex.Message}";
        //    }
        //    return resposta;
        //}
    }
}
