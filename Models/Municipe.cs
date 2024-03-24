using BairroConnectAPI.Models.Enuns;
using Microsoft.VisualBasic;

namespace BairroConnectAPI.Models
{

    public class Municipe : Logins
    {
       public int idMunicipe { get; set; }
       public string estado { get; set; } = string.Empty;
       public string cidade { get; set; } = string.Empty;
      

    }
}