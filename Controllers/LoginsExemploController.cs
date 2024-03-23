using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BairroConnectAPI.Models;
using BairroConnectAPI.Models.Enuns;


namespace BairroConnectAPI.Controllers
{
    [ApiController]
    [Route ("[Controller]")]
    public class LoginsExemploController : ControllerBase
    {

        private static List<Logins> logins = new List<Logins>()
        {

            new Logins() { idPessoa = 1, nome = "Carlos", sobrenome = "Silva", email = "carlos.e.789999@gmail.com", dataNasc = 28/08/2006,  tipoConta = TipoConta.Organizador }
        
        };
        

        public IActionResult GetFirst()
        {
            Logins l = logins[0];
            return Ok(l);
        }
        public IActionResult GetAll()
        {
            return Ok(logins);
        }


    }
}