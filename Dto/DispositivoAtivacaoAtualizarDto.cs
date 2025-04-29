namespace Silento.Dto
{
    public class DispositivoAtivacaoAtualizarDto
    {
        public long Id { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime? HoraFim { get; set; }
        public DateTime HoraLimite { get; set; }
        public Guid IdDispositivo { get; set; }
        public int IdEstado { get; set; }

    }
}
