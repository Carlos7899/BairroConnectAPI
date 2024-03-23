using BairroConnectAPI.Models.Enuns;
using Microsoft.VisualBasic;

namespace BairroConnectAPI.Models
{

    public class Logins
    {
        public int idPessoa {get; set; }       
        public string nome {get; set; } = string.Empty;
        public string sobrenome {get; set; } = string.Empty;
        public string email {get; set; } = string.Empty;
        public DateFormat dataNasc { get; set; }   // revisar esse aqui
        public TipoConta tipoConta { get; set; }


    }


}