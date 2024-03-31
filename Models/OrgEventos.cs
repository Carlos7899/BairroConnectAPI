namespace BairroConnectAPI.Models
{
    public class OrgEventos : Logins
    {
       public int idOrganizador { get; set; }
       public string profissao { get; set; } = string.Empty;
       public string empresa { get; set; } = string.Empty;
       public string telOrganizador { get; set; } = string.Empty;
    }
}