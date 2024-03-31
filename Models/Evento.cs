namespace BairroConnectAPI.Models
{
    public class Evento
    {
        public int idEvento { get; set; }
        public int idOrganizador { get; set; }
        public string titulo { get; set; } = string.Empty;
        public DateOnly dataInicio { get; set; }
        public DateOnly dataFim { get; set; }
        public int limiteParticipantes { get; set; }
        public string descricao { get; set; } = string.Empty;
        public int valorIngresso { get; set; }
        public TimeOnly horaInicio { get; set; }
        public TimeOnly horaFim { get; set; }
    }
}