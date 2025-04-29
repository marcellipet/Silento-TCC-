using Silento.Services.AtivacaoEstado;
using Silento.Services.Dispositivo;
using Silento.Services.DispositivoAtivacao;
using Silento.Services.Endereco;

namespace Silento.Extensions
{
    public static class ServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IDispositivoInterface, DispositivoService>();
            services.AddTransient<IAtivacaoEstadoInterface, AtivacaoEstadoService>();
            services.AddTransient<IEnderecoInterface, EnderecoService>();
            services.AddTransient<IDispositivoAtivacaoInterface, DispositivoAtivacaoService>();
        }
    }
}
