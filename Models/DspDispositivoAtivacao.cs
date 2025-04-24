using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Silento.Models
{
    [Table("Dsp_DispositivoAtivacao")]
    public class DspDispositivoAtivacao
    {
        [Key]
        public long Id { get; protected set; }

        [Required]
        public DateTime HoraInicio { get; set; }

        [AllowNull]
        public DateTime HoraFim { get; set; }

        [Required]
        public DateTime HoraLimite { get; set; }

        [ForeignKey(nameof(Pk_Dispositivo))]
        public Guid IdDispositivo { get; set; }

        public DspDispositivo Pk_Dispositivo { get; init; }

        [ForeignKey(nameof(Pk_AtivacaoEstado))]
        public long IdEstado { get; set; }

        public DspDispositivo Pk_AtivacaoEstado { get; init; }
    }
}
