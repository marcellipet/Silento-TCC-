using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Silento.Models
{
    public class EndEndereco
    {
        [Key]
        public long Id { get; protected set; }

        [Required]
        public string CEP { get; set; }

        [Required]
        public char Estado { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Logradouro { get; set; }

        [Required]
        public bool IsActive { get; set; } = false;

        [ForeignKey(nameof(Pk_Dispositivo))]
        public Guid IdDispositivo { get; set; }

        public DspDispositivo Pk_Dispositivo { get; init; }
    }
}
