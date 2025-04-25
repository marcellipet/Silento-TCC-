using System.ComponentModel.DataAnnotations;

namespace Silento.Dto
{
    public class AtivacaoAtualizarDto
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
