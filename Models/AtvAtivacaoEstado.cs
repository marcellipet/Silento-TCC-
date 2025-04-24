using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Silento.Models
{
    [Table("Atv_AtivacaoEstado")]
    public class AtvAtivacaoEstado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [StringLength(180)]
        public string Descricao { get; set; }
    }
}
