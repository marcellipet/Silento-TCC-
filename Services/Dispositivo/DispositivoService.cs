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

        public async Task<ResponseModel<DspDispositivo>> BuscarPeloId(Guid id)
        {
            ResponseModel<DspDispositivo> resposta = new ResponseModel<DspDispositivo>();
            try
            {
                // verifica se o banco de dados está acessível
                var dispositivo = await _context.DspDispositivo.FirstOrDefaultAsync(d => d.Id == id);
                // verifica se a lista de dispositivos está vazia ou nula
                if (dispositivo == null)
                {
                    // se o statuus for falso retorna uma mensagem de erro
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                // verifica se a lista de dispositivos contém elementos
                resposta.Dados = dispositivo;
                // se o status for verdade retorna sucesso 
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos encontrados com sucesso.";
            }
            // trata exceções 
            catch (Exception ex)
            {
                // se o status for falso retorna uma mensagem de erro
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
            }
            return resposta;
        }

        //public Task<ResponseModel<List<DspDispositivo>>> BuscarPorAtivacao(int idAtvEstado)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<ResponseModel<List<DspDispositivo>>> BuscarPorAtivacao(int idAtvEstado)
        //{
        //    ResponseModel<List<DspDispositivo>> resposta = new ResponseModel<List<DspDispositivo>>();
        //    try
        //    {
        //        var dispositivos = await _context.DspDispositivo.Where(d => d.Id.Equals(id)).ToListAsync();
        //        if (dispositivos == null || dispositivos.Count == 0)
        //        {
        //            resposta.Status = false;
        //            resposta.Mensagem = "Nenhum dispositivo encontrado.";
        //            return resposta;
        //        }
        //        resposta.Dados = dispositivos;
        //        resposta.Status = true;
        //        resposta.Mensagem = "Dispositivos encontrados com sucesso.";
        //    }
        //    catch (Exception ex)
        //    {
        //        resposta.Status = false;
        //        resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
        //    }
        //    return resposta;
        //}

        //public async  Task<ResponseModel<DspDispositivo>> BuscarPorEndereco(long idEndereco)
        //{
        //    ResponseModel<DspDispositivo> resposta = new ResponseModel<DspDispositivo>();

        //    try
        //    {
        //        var dispositivo = _context.DspDispositivo.FirstOrDefaultAsync(d => d.IdEndereco == idEndereco);
        //        if (dispositivo == null)
        //        {
        //            resposta.Status = false;
        //            resposta.Mensagem = "Nenhum dispositivo encontrado.";
        //            return resposta;
        //        }
        //        resposta.Dados = dispositivo.Result;
        //        resposta.Status = true;
        //        resposta.Mensagem = "Dispositivos encontrados com sucesso.";
        //    }
        //    catch (Exception ex)
        //    {
        //        resposta.Status = false;
        //        resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
        //    }
        //}

        public async Task<ResponseModel<DspDispositivo>> BuscarPorIp(string idIp)
        {
            ResponseModel<DspDispositivo> resposta = new ResponseModel<DspDispositivo>();

            try
            {
                var dispositivo = _context.DspDispositivo.FirstOrDefaultAsync(d => d.IpShield == idIp);

                if (dispositivo == null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }

                resposta.Dados = dispositivo.Result;
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

        public async Task<ResponseModel<List<DspDispositivo>>> BuscarPorStatus(bool status)
        {
            ResponseModel<List<DspDispositivo>> resposta = new ResponseModel<List<DspDispositivo>>();

            try
            {
                var dispositivos = await _context.DspDispositivo.Where(d => d.StatusDisp == status).ToListAsync();
                if (dispositivos == null || dispositivos.Count == 0)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                resposta.Dados = dispositivos;
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

        public async Task<ResponseModel<List<DspDispositivo>>> BuscarTodos()
        {

            ResponseModel<List<DspDispositivo>> resposta = new ResponseModel<List<DspDispositivo>>();
            try
            {
                // entra no banco e ver se esta acessível
                var dispositivos = await _context.DspDispositivo.ToListAsync();

                // verifica se a lista de dispositivos está vazia ou nula
                if (dispositivos == null || dispositivos.Count == 0)
                {
                    // se o statuus for falso retorna uma mensagem de erro
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }

                // verifica se a lista de dispositivos contém elementos
                resposta.Dados = dispositivos;
                // se o status for verdade retorna sucesso 
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos encontrados com sucesso.";
            }
            // trata exceções 
            catch (Exception ex)
            {
                // se o status for falso retorna uma mensagem de erro
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao buscar dispositivos: {ex.Message}";
            }
            return resposta;

        }

        public async Task<ResponseModel<DspDispositivo>> Criar(DspDispositivo dispositivo)
        {
            ResponseModel<DspDispositivo> resposta = new ResponseModel<DspDispositivo>();
            try
            {
                _context.DspDispositivo.Add(dispositivo);
                _context.SaveChanges();

                resposta.Dados = dispositivo;
                resposta.Status = true;
                resposta.Mensagem = "Dispositivo criado com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao criar dispositivo: {ex.Message}";
            }
            return resposta;
        }

        public async Task<ResponseModel<List<bool>>> Deletar(bool StatusDisp)
        {
            ResponseModel<List<bool>> resposta = new ResponseModel<List<bool>>();
            try
            {
                var dispositivos = await _context.DspDispositivo.Where(d => d.StatusDisp == StatusDisp).ToListAsync();
                if (dispositivos == null || dispositivos.Count == 0)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "Nenhum dispositivo encontrado.";
                    return resposta;
                }
                _context.DspDispositivo.RemoveRange(dispositivos);
                await _context.SaveChangesAsync();
                resposta.Dados = new List<bool> { true };
                resposta.Status = true;
                resposta.Mensagem = "Dispositivos deletados com sucesso.";
            }
            catch (Exception ex)
            {
                resposta.Status = false;
                resposta.Mensagem = $"Erro ao deletar dispositivos: {ex.Message}";
            }
            return resposta;
        }

    }
}
