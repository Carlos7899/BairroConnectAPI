namespace BairroConnectAPI.Models
{
    public class EventoMunicipe
    {
       public int idEventoMunicipe { get; set; }
       public int idMunicipe { get; set; }
       public int idEvento { get; set; }
       public TimeOnly horaInicio { get; set; }
       public TimeOnly horaFim { get; set; }
    }
}