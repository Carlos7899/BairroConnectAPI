namespace BairroConnectAPI.Models
{
    public class EventoParticipante
    {
       public int idEvento { get; set; }
       public TimeOnly horaParticipacao { get; set; }
       public int limiteParticipantesHora { get; set; }
    }
}