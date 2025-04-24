using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Silento.Models
{
    [Table("Dsp_Dispositivo")]
    public class DspDispositivo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(20)]
        public string IpShield { get; set; }

        [Required]
        public bool StatusDisp { get; set; } = false;

        [Required]
        public string Decibeis { get; set; } = "0";

        [Required]
        public string LimiteDecibeis { get; set; }
    }
}
