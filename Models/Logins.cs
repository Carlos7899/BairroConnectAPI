using BairroConnectAPI.Models.Enuns;
using System.ComponentModel.DataAnnotations.Schema;

namespace BairroConnectAPI.Models
{
    public class Logins
    {
        public int idPessoa { get; set; }       
        public string nome { get; set; } = string.Empty;
        public string sobrenome { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        [NotMapped]
        public DateOnly dataNasc { get; set; }  
        public TipoConta tipoConta { get; set; }
    }
}