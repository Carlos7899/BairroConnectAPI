using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BairroConnectAPI.Models;
using BairroConnectAPI.Models.Enuns;
using System.Linq;


namespace BairroConnectAPI.Controllers
{
    [ApiController]
    [Route ("[Controller]")]
    public class LoginsExemploController : ControllerBase
    {

        private static List<Logins> logins = new List<Logins>()
        {

            new Logins() {  idPessoa = 1, nome = "Carlos", sobrenome = "Silva", email = "carlos.e.789999@gmail.com", dataNasc = new DateOnly(2006, 08, 28), tipoConta = TipoConta.Organizador },
            new Logins() {  idPessoa = 2, nome = "Daniel", sobrenome = "Silva", email = "daniel.silva@gmail.com", dataNasc = new DateOnly(2006, 04, 08), tipoConta = TipoConta.Organizador    },
            new Logins() {  idPessoa = 3, nome = "teste", sobrenome = "teste", email = "teste.e.@gmail.com", dataNasc = new DateOnly(2006, 08, 28),  tipoConta = TipoConta.Municipe           }
        
        };
        

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Logins l = logins[0];
            return Ok(l);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(logins);
        }

        [HttpGet("{idPessoa}")]
        public IActionResult GetSingle(int idPessoa)
        {
            var login = logins.FirstOrDefault(lo => lo.idPessoa == idPessoa);
            if (login != null)
                return Ok(login);
            else
                return NotFound($"Login com id {idPessoa} não encontrado.");
        }


        //revisar os de baixo

        [HttpPost("Add")]
        public IActionResult AddLogin(Logins newLogin)
        {
            // Supondo que não há verificação de duplicatas
            logins.Add(newLogin);
            return CreatedAtAction(nameof(GetSingle), new { idPessoa = newLogin.idPessoa }, newLogin);
        }

        [HttpPut("{idPessoa}")]
        public IActionResult UpdateLogin(int idPessoa, Logins updatedLogin)
        {
            var existingLogin = logins.FirstOrDefault(lo => lo.idPessoa == idPessoa);
            if (existingLogin == null)
                return NotFound($"Login com id {idPessoa} não encontrado.");

            existingLogin.nome = updatedLogin.nome;
            existingLogin.sobrenome = updatedLogin.sobrenome;
            existingLogin.email = updatedLogin.email;
            existingLogin.dataNasc = updatedLogin.dataNasc;
            existingLogin.tipoConta = updatedLogin.tipoConta;

            return Ok(existingLogin);
        }

        [HttpDelete("{idPessoa}")]
        public IActionResult DeleteLogin(int idPessoa)
        {
            var loginToRemove = logins.FirstOrDefault(lo => lo.idPessoa == idPessoa);
            if (loginToRemove == null)
                return NotFound($"Login com id {idPessoa} não encontrado.");

            logins.Remove(loginToRemove);
            return Ok(loginToRemove);
        }

        [HttpGet("GetByEmail")]
        public IActionResult GetByEmail(string email)
        {
            var login = logins.FirstOrDefault(lo => lo.email == email);
            if (login != null)
                return Ok(login);
            else
                return NotFound($"Login com email '{email}' não encontrado.");
        }





    }
}