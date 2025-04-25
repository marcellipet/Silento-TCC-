using Silento.Services.Dispositivo;

namespace Silento.Extensions
{
    public static class ServiceExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IDispositivoInterface, DispositivoService>();
        }
    }
}
