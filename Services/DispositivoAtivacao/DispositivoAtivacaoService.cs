using Silento.Data;

namespace Silento.Services.DispositivoAtivacao
{
    public class DispositivoAtivacaoService : IDispositivoAtivacaoInterface
    {
        private readonly AppDbContext context;
        public DispositivoAtivacaoService(AppDbContext context)
        {
            context = context;
        }

    }
}
