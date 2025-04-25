using Silento.Data;

namespace Silento.Services.Dispositivo
{
    public class DispositivoService : IDispositivoInterface
    {
        private readonly AppDbContext _context;
        public DispositivoService(AppDbContext context)
        {
            _context = context;
        }
    }
    
    
}
