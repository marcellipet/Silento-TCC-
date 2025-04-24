using Microsoft.EntityFrameworkCore;
using Silento.Models;

namespace Silento.Data
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AtvAtivacaoEstado> AtvAtivacaoEstado { get; set; }
        public DbSet<DspDispositivo> DspDispositivo { get; set; }
        public DbSet<DspDispositivoAtivacao> DspDispositivoAtivacao { get; set; }
        public DbSet<EndEndereco> EndEndereco { get; set; }
    }
}
